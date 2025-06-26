using System;
using System.Collections.Generic;
using System.Text;

namespace CyberSecurityChatbotGUI // Or your main project namespace
{
    public class ActivityLog
    {
        private List<string> _logEntries;

        public ActivityLog()
        {
            _logEntries = new List<string>();
        }

        public void LogActivity(string action) // Renamed from LogAction
        {
            _logEntries.Add($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {action}");
        }

        public string GetActivityLog() // Renamed from GetLog
        {
            if (_logEntries.Count == 0)
            {
                return "Activity log is empty.";
            }

            StringBuilder sb = new StringBuilder("--- Activity Log ---\n");
            foreach (var entry in _logEntries)
            {
                sb.AppendLine(entry);
            }
            return sb.ToString();
        }
    }
}