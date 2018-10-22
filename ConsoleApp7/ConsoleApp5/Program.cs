using System;
using System.Drawing;
using System.Windows.Forms;

//class Program : Form
//{
//    public void MouseHandler(object sender, MouseEventArgs e)
//    {
//        Console.WriteLine("Sender : " + ((Form)sender).Text);
//        Console.WriteLine("Sender : " + ((Form)sender).Name);
//        Console.WriteLine("X:{0}, Y:{1}",e.X,e.Y);
//        Console.WriteLine("Button:{0}, Clicks:{1}",e.Button, e.Clicks);
//    }
//    public Program(String title)
//    {
//        this.Text = title;
//        this.Name = "윈폼";
//        this.MouseDown += new MouseEventHandler(MouseHandler);
//    }
//    static void Main(string[] args)
//    {
//        Application.Run(new Program("마우스 이벤트 예제"));
//    }
//}

class Program : Form
{
    Random r;
    public Program()
    {
        r = new Random();
        this.MouseWheel += new MouseEventHandler(OnjMouseWheel);
        this.MouseDown += new MouseEventHandler(OnjMouseDown);
    }
    void OnjMouseDown(object sender, MouseEventArgs e)
    {
        if(e.Button == MouseButtons.Left)
        {
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            Color oldcolor = this.BackColor;
            this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
        }
        if(e.Button == MouseButtons.Right)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
    void OnjMouseWheel(object sender, MouseEventArgs e)
    {
        this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1 : -0.1);
        Console.WriteLine("Opacity : {0}", this.Opacity);
    }
    static void Main(string[] args)
    {
        Application.Run(new Program());
    }
}
