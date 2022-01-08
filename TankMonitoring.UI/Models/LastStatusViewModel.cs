using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TankMonitoring.UI.Enums;
//using TankMonitoring.Data.Models;

namespace TankMonitoring.UI.Models
{
    public class LastStatusViewModel
    {

        public LastStatusViewModel()
        {

        }
        public LastStatusViewModel(decimal TankId)
        {

            switch (TankId)
            {
                case 1:
                    R_Val = (int?)ProductColors.T01_R;
                    G_Val = (int?)ProductColors.T01_G;
                    B_Val = (int?)ProductColors.T01_B;
                    break;
                case 2:
                    R_Val = (int?)ProductColors.T02_R;
                    G_Val = (int?)ProductColors.T02_G;
                    B_Val = (int?)ProductColors.T02_B;
                    break;
                case 3:
                    R_Val = (int?)ProductColors.T03_R;
                    G_Val = (int?)ProductColors.T03_G;
                    B_Val = (int?)ProductColors.T03_B;
                    break;
                case 4:
                    R_Val = (int?)ProductColors.T04_R;
                    G_Val = (int?)ProductColors.T04_G;
                    B_Val = (int?)ProductColors.T04_B;
                    break;
                case 5:
                    R_Val = (int?)ProductColors.T05_R;
                    G_Val = (int?)ProductColors.T05_G;
                    B_Val = (int?)ProductColors.T05_B;
                    break;
                case 6:
                    R_Val = (int?)ProductColors.T06_R;
                    G_Val = (int?)ProductColors.T06_G;
                    B_Val = (int?)ProductColors.T06_B;
                    break;
                case 7:
                    R_Val = (int?)ProductColors.T07_R;
                    G_Val = (int?)ProductColors.T07_G;
                    B_Val = (int?)ProductColors.T07_B;
                    break;
                case 8:
                    R_Val = (int?)ProductColors.T08_R;
                    G_Val = (int?)ProductColors.T08_G;
                    B_Val = (int?)ProductColors.T08_B;
                    break;
                case 9:
                    R_Val = (int?)ProductColors.T09_R;
                    G_Val = (int?)ProductColors.T09_G;
                    B_Val = (int?)ProductColors.T09_B;
                    break;
                case 10:
                    R_Val = (int?)ProductColors.T10_R;
                    G_Val = (int?)ProductColors.T10_G;
                    B_Val = (int?)ProductColors.T10_B;
                    break;
                case 11:
                    R_Val = (int?)ProductColors.T11_R;
                    G_Val = (int?)ProductColors.T11_G;
                    B_Val = (int?)ProductColors.T11_B;
                    break;
                case 12:
                    R_Val = (int?)ProductColors.T12_R;
                    G_Val = (int?)ProductColors.T12_G;
                    B_Val = (int?)ProductColors.T12_B;
                    break;
                case 13:
                    R_Val = (int?)ProductColors.T13_R;
                    G_Val = (int?)ProductColors.T13_G;
                    B_Val = (int?)ProductColors.T13_B;
                    break;
                case 14:
                    R_Val = (int?)ProductColors.T14_R;
                    G_Val = (int?)ProductColors.T14_G;
                    B_Val = (int?)ProductColors.T14_B;
                    break;
                case 15:
                    R_Val = (int?)ProductColors.T15_R;
                    G_Val = (int?)ProductColors.T15_G;
                    B_Val = (int?)ProductColors.T15_B;
                    break;
                case 16:
                    R_Val = (int?)ProductColors.T16_R;
                    G_Val = (int?)ProductColors.T16_G;
                    B_Val = (int?)ProductColors.T16_B;
                    break;
                case 17:
                    R_Val = (int?)ProductColors.T17_R;
                    G_Val = (int?)ProductColors.T17_G;
                    B_Val = (int?)ProductColors.T17_B;
                    break;
                case 18:
                    R_Val = (int?)ProductColors.T18_R;
                    G_Val = (int?)ProductColors.T18_G;
                    B_Val = (int?)ProductColors.T18_B;
                    break;

            }

        }

        public string? Name { get; set; }
        public string? ProductName { get; set; }
        public float? Level { get; set; }
        public decimal? FlowRate { get; set; }
        public decimal? AvgTemp { get; set; }
        public decimal? TOV { get; set; }
        public decimal? NSV { get; set; }
        public decimal? WIA { get; set; }
        public decimal? VCF { get; set; }
        public int? TankID { get; set; }
        public int? R_Val { get; set; }
        public int? G_Val { get; set; }
        public int? B_Val { get; set; }
        public double? Density { get; set; }
        public float? CapacityHeight { get; set; }
        public float? TankHeight { get; set; }
        public DateTime? TankDate { get; set; }
        public DateTime? TankCurrentDate { get; set; }
        public int TankTransactionID { get; set; }
        public string TankNameF { get; set; }

        public DateTime? StartDateF { get; set; }

        public DateTime? EndDateF { get; set; }
        public float? VaporPressure { get; set; }
        public float? GOV { get; set; }
        public float GetAvailableRoom()
        {
            return (float)(CapacityHeight - (float)TOV);
        }





    }
}
