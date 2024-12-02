using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agecalculator
{
    public partial class agecalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /* for birthdate */
            string birthDate=txt_brt_dte.Text;
            int birthYear = Convert.ToDateTime(birthDate).Year;
            int birthMonth = Convert.ToDateTime(birthDate).Month;
            int birthDay = Convert.ToDateTime(birthDate).Day;


            /* for current_date */
            string curntDate = txt_crnt_date.Text;
            int crntYear = Convert.ToDateTime(curntDate).Year;
            int crntMonth = Convert.ToDateTime(curntDate).Month;
            int crnDay = Convert.ToDateTime(curntDate).Day;

            //Response.Write("Birth Year "+birthYear);
            //Response.Write("Current Year "+ crntYear);

            /* for calculating age */
            int ageYear = crntYear - birthYear;
            int ageMonth;
            int ageDay;

            /* for calculating month difference */
            int monthDifference = crntMonth - birthMonth;
            /* for calculating days difference */
            int daysDifference = crnDay - birthDay;

            if (daysDifference <= 0)
            {
                ageDay = 0;
            }
            else {
                ageDay = daysDifference; 
            }

            if (monthDifference <= 0)
            {
                ageMonth = 0;
            }
            else
            {
                ageMonth = monthDifference;
            }



            Response.Write("Your age is :" + ageDay + "/" + ageMonth + "/" + ageYear);
        }
    }
}