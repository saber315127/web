using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public class Global

    {
        public static int a = 1;

    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Global.a %2==1)
        {
            TextBox10.Text = "";
            TextBox1.Text = "X";
                if ((TextBox2.Text == TextBox1.Text) && (TextBox3.Text == TextBox1.Text))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox4.Text == "X") && (TextBox7.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "X") && (TextBox9.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
            
            
        }
        else
        {
            TextBox10.Text = "";
            TextBox1.Text = "O";
                if ((TextBox2.Text == "O") && (TextBox3.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox4.Text == "O") && (TextBox7.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "O") && (TextBox9.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
           
            
        }
        if (Global.a>=9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Global.a % 2 == 1)
        {
            TextBox10.Text = "";
            TextBox2.Text = "X";
                if ((TextBox1.Text == "X") && (TextBox3.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "X") && (TextBox6.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
           
            
        }
        else
        {
            TextBox10.Text = "";
            TextBox2.Text = "O";
                if ((TextBox1.Text == "O") && (TextBox3.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "O") && (TextBox6.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
            
            
        }
        if (Global.a >= 9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Global.a % 2 == 1)
        {
            TextBox10.Text = "";
            TextBox3.Text = "X";
                if ((TextBox1.Text == "X") && (TextBox2.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox6.Text == "X") && (TextBox9.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "X") && (TextBox7.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }

            
            
        }
        else
        {
            TextBox10.Text = "";
            TextBox3.Text = "O";
                if ((TextBox6.Text == "O") && (TextBox9.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox1.Text == "O") && (TextBox2.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "O") && (TextBox7.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                
            
            
        }
        if (Global.a >= 9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        
            if (TextBox4.Text == "")
            {
                TextBox4.Text = "X";
                if ((TextBox1.Text == "X") && (TextBox7.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "X") && (TextBox6.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
            
            
        }
        else
        {
            TextBox10.Text = "";
            TextBox4.Text = "O";
                if ((TextBox1.Text == "O") && (TextBox7.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "O") && (TextBox6.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
           
            
        }
        if (Global.a >= 9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (Global.a % 2 == 1)
        {
            TextBox10.Text = "";
            TextBox5.Text = "X";
                if ((TextBox6.Text == "X") && (TextBox4.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox8.Text == "X") && (TextBox2.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox3.Text == "X") && (TextBox7.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox1.Text == "X") && (TextBox9.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
            
            
        }
        else
        {
            TextBox10.Text = "";
            TextBox5.Text = "O";
                if ((TextBox6.Text == "O") && (TextBox4.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox8.Text == "O") && (TextBox2.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox3.Text == "O") && (TextBox7.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox1.Text == "O") && (TextBox9.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
            
            
        }
        if (Global.a >= 9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        if (Global.a % 2 == 1)
        {
            
                TextBox6.Text = "X";
                if ((TextBox3.Text == "X") && (TextBox9.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "X") && (TextBox4.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
            
            
        }
        else
        {
            
                TextBox6.Text = "O";
                if ((TextBox3.Text == "O") && (TextBox9.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "O") && (TextBox4.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
           
            
        }
        if (Global.a >= 9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        if (Global.a % 2 == 1)
        {
            TextBox10.Text = "";
            TextBox7.Text = "X";
                if ((TextBox1.Text == "X") && (TextBox4.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "X") && (TextBox3.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox8.Text == "X") && (TextBox9.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
           
            
        }
        else
        {
            
                TextBox7.Text = "O";
                if ((TextBox1.Text == "O") && (TextBox4.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox5.Text == "O") && (TextBox3.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox8.Text == "O") && (TextBox9.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
           
            
        }
        if (Global.a >= 9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        if (Global.a % 2 == 1)
        {
            TextBox10.Text = "";
            TextBox8.Text = "X";
                if ((TextBox2.Text == "X") && (TextBox5.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox7.Text == "X") && (TextBox9.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
           
            
        }
        else
        {
            
                TextBox8.Text = "O";
                if ((TextBox2.Text == "O") && (TextBox5.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox7.Text == "O") && (TextBox9.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
            
            
        }
        if (Global.a >= 9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        if (Global.a % 2 == 1)
        {
            TextBox10.Text = "";
            if (TextBox9.Text != "X" || TextBox9.Text != "O")
            {
                TextBox9.Text = "X";
                if ((TextBox3.Text == "X") && (TextBox6.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox7.Text == "X") && (TextBox8.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
                if ((TextBox1.Text == "X") && (TextBox5.Text == "X"))
                {
                    TextBox10.Text = "X is winner";
                    Global.a = 10;
                }
            }
            else
            {
                TextBox10.Text = "已經被選了";
            }
            
            
        }
        else
        {
            if (TextBox9.Text != "X" || TextBox9.Text != "O")
            {
                TextBox10.Text = "";
                TextBox9.Text = "O";
                if ((TextBox3.Text == "O") && (TextBox6.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox7.Text == "O") && (TextBox8.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
                if ((TextBox1.Text == "O") && (TextBox5.Text == "O"))
                {
                    TextBox10.Text = "O is winner";
                    Global.a = 10;
                }
            }
            else
            {
                TextBox10.Text = "已經被選了";
                Global.a -= 1;
            }
            
        }
        if (Global.a >= 9)
        {
            TextBox1.Text = "1";
            TextBox2.Text = "2";
            TextBox3.Text = "3";
            TextBox4.Text = "4";
            TextBox5.Text = "5";
            TextBox6.Text = "6";
            TextBox7.Text = "7";
            TextBox8.Text = "8";
            TextBox9.Text = "9";
            Global.a = 1;
            if (Global.a == 9)
            {
                TextBox10.Text = "遊戲結束";
            }
        }
        else
        {
            Global.a += 1;
        }
    }
}