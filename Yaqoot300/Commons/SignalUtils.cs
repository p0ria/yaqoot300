using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Yaqoot300.Interfaces;
using Yaqoot300.Models.Signal;

namespace Yaqoot300.Commons
{
    public static class SignalUtils
    {
        static SignalUtils()
        {
            ExtractPlcSignals();
            ExtractGuiSignals();
        }

        public static List<Signal> PlcSignals { get; private set; }
        public static List<Signal> GuiSignals { get; private set; }

        private static void ExtractPlcSignals()
        {
            var pis = ExtractSignalProps<PlcSignals>();
            var signals = new List<Signal>();
            foreach (var pi in pis)
            {
                var sr = pi.GetCustomAttribute<SignalAttribute>();
                var signal = new Signal
                {
                    Name = pi.Name,
                    value = sr.Index
                };
                signals.Add(signal);
            }
            PlcSignals = signals;
        }

        public static string GetPlcSignalName(byte[] bytes)
        {
            var signal = SignalUtils.PlcSignals.FirstOrDefault(s =>
            {
                for (var i = 0; i < bytes.Length && i < s.value.Length; i++)
                {
                    if ((bytes[i] ^ s.value[i]) != 0) return false;
                }
                return true;
            });
            return signal?.Name ?? "";
        }

        public static string GetGuiSignalName(byte[] bytes)
        {
            var signal = SignalUtils.GuiSignals.FirstOrDefault(s =>
            {
                for (var i = 0; i < bytes.Length && i < s.value.Length; i++)
                {
                    if ((bytes[i] ^ s.value[i]) != 0) return false;
                }
                return true;
            });
            return signal?.Name ?? "";
        }

        private static void ExtractGuiSignals()
        {
            var fields = typeof(GuiSignals).GetFields(BindingFlags.Public | BindingFlags.Static);
            var signals = new List<Signal>();
            foreach (var field in fields)
            {
                var signal = new Signal
                {
                    Name = field.Name,
                    value = (byte[])field.GetValue(null)
                };
                signals.Add(signal);
            }
            GuiSignals = signals;
        }

        private static IEnumerable<PropertyInfo> ExtractSignalProps<T>()
        {
            return typeof(T)
                .GetProperties()
                .Where(p => p.GetCustomAttribute<SignalAttribute>() != null);
        }
    }
}
