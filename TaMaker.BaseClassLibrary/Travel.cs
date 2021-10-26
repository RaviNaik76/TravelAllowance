using System;
using System.ComponentModel.DataAnnotations;

namespace TaMaker.BaseClassLibrary
{
    public class Travel
    {
        [Required]
        public string Dep_Place { get; set; }
        [Required]
        public DateTime Dep_Date { get; set; }
        [Required]
        public string Arr_Place { get; set; }
        [Required]
        public DateTime Arr_Date { get; set; }
        [Required]
        public int Dest_Kms { get; set; }
        [Required]
        public string Jou_Reason { get; set; }
        public string Halt_Place { get; set; }
        [Required]
        public double DayRate { get; set; }
        [Required]
        [Range(0.5, 30)]
        public double NoOfDay { get; set; }
        [Required]
        public double FareAmt { get; set; }
        [Required]
        public double TotalTA { get; set; }
        public double AdvanceTA { get; set; }
        [Required]
        public string Jou_Mode { get; set; }
        public string Warrant_No { get; set; }
        [Required]
        public string Shd_No { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public int EmpNo { get; set; }
        [Required]
        public int GroupNo { get; set; }
        [Required]
        public string MonthYear { get; set; }
        public string Remarks { get; set; }
    }
}
