using System.ComponentModel.DataAnnotations;

namespace PomodoroTimer.Models
{
    public class PomodoroSettings
    {
        [Range(1, 60, ErrorMessage = "工作時間必須在1到60分鐘之間")]
        [Display(Name = "工作時間（分鐘）")]
        public int WorkDuration { get; set; } = 25;

        [Range(1, 30, ErrorMessage = "休息時間必須在1到30分鐘之間")]
        [Display(Name = "短休息時間（分鐘）")]
        public int ShortBreakDuration { get; set; } = 5;

        [Range(1, 60, ErrorMessage = "長休息時間必須在1到60分鐘之間")]
        [Display(Name = "長休息時間（分鐘）")]
        public int LongBreakDuration { get; set; } = 15;

        [Range(1, 10, ErrorMessage = "長休息間隔必須在1到10之間")]
        [Display(Name = "長休息間隔（番茄數）")]
        public int LongBreakInterval { get; set; } = 4;
    }
}