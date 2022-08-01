using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssignmentProgram
{
    public partial class Marksheet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttoncalculate_Click(object sender, EventArgs e)
        {
            String name1=name.Text;
            int sub1=Convert.ToUInt16(TextBoxsub1.Text);
            int sub2 = Convert.ToUInt16(TextBoxsub2.Text);
            int sub3 = Convert.ToUInt16(TextBoxsub3.Text);
            Labelresultname.Text = name1;
            int sum = sub1 + sub2 + sub3;
            int persentage = sum / 3;
            Labelresultsub1.Text = sub1.ToString();
            Labelresultsub2.Text = sub2.ToString();
            Labelresultsub3.Text = sub3.ToString();
            Labelresultsum.Text = sum.ToString();
            Labelresultpersentage.Text = persentage.ToString();
            if (persentage <= 30)
            {
                Labelresultgrade.Text = "You Are A Fail";
            }
            else if(persentage <= 50)
            {
                Labelresultgrade.Text = "You Got A D Grade";
            }
            else if (persentage <= 70)
            {
                Labelresultgrade.Text = "You Got A C Grade";
            }
            else if (persentage <= 80)
            {
                Labelresultgrade.Text = "You Got A B Grade";
            }
            else if (persentage <= 90)
            {
                Labelresultgrade.Text = "You Got A A Grade";
            }
            else if (persentage <= 99)
            {
                Labelresultgrade.Text = "You Got A A+ Grade";
            }
            else
            {
                Labelresultgrade.Text = "!!!!! Enter The Right Mark In The Field !!!!!!";
            }
        }
    }
}