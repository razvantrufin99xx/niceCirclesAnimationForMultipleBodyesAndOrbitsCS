/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/8/2024
 * Time: 12:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace rotatingCircle
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Graphics g;
		
		public bool runningison = false;
		
		public Pen p = new Pen(Color.FromArgb(255,0,0,0),1);
		public Brush b = new SolidBrush(Color.Black);
		public double rad = 180/Math.PI;
		public class cerc
		{
			public float x;
			public float y;
			public float rx;
			public float ry;
			public float rot;
		}
		public List<cerc>cercuri = new List<cerc>();
		
		void MainFormLoad(object sender, EventArgs e)
		{
				g = this.panel1.CreateGraphics();
				cercuri.Add(new cerc());
				cercuri.Add(new cerc());
				cercuri.Add(new cerc());
				cercuri.Add(new cerc());
		}
		void Button1Click(object sender, EventArgs e)
		{
			//runh12();
			/*
			runOneTime();
			rotateCircle(90);
			rotateCircle(45);
			rotateCircle(35);
			rotateCircle(180+90);
			rotateCircle(270+45);
			*/
			 for(float i = 0.0f ; i<50; i+=1)
			 {
				rotatingCircleAnimation();
			 }
			//rotatingCircleAnimationNoErasing();
			
		}
		
		public void draw(int L, int T, float rx, float ry, float startangle, int dimx, int dimy)
		{
			
			 
					 
			 
			 
			 
			 double  x = L*(Math.Cos(0/rad))+rx;
			 double  y = T*(Math.Sin(0/rad))+ry;
			 
			 double px = x;
			 double py = y;
			
			 
			  	
			 for(float i = startangle ; i<360+startangle+10; i+=10)
			 {
			 	
			 	//g.Clear(Color.White);
			 	
			 	x = L*(Math.Cos(i/rad))+rx;
			 	y = T*(Math.Sin(i/rad))+ry;
			 
			 	//g.DrawLine(p,(float)x,(float)y,(float)px,(float)py);
			 	if(i==startangle)
			 	 {
			 		 //g.DrawEllipse(p,(float)x-dimx/2,(float)y-dimy/2,dimx,dimy);
			 		 g.DrawEllipse(p,(float)(rx-L),(float)(ry-T),(float)(L*2),(float)(T*2));
			 		 g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 		 cercuri[0].x = (float)x;
			 		 cercuri[0].y = (float)y;
			 		 cercuri[0].rx = (float)rx;
			 		 cercuri[0].ry = (float)ry;
			 		 cercuri[0].rot = startangle;
			 	}
			 	//g.DrawLine(p,(float)rx,(float)ry,(float)(px),(float)(py));
			 	//g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 	
			 	px = x;
			 	py = y;
			 	
			 	//Thread.Sleep(1);
			 }
			 runningison=false;
			 button1.Enabled = true;
		}
		
		public void drawSecond(int L, int T, float rx, float ry, float startangle, int dimx, int dimy)
		{
			
			 
					 
			 
			 
			 
			 double  x = L*(Math.Cos(0/rad))+rx;
			 double  y = T*(Math.Sin(0/rad))+ry;
			 
			 double px = x;
			 double py = y;
			
			 
			  	
			 for(float i = startangle ; i<360+startangle+10; i+=10)
			 {
			 	
			 	//g.Clear(Color.White);
			 	
			 	x = L*(Math.Cos(i/rad))+rx;
			 	y = T*(Math.Sin(i/rad))+ry;
			 
			 	//g.DrawLine(p,(float)x,(float)y,(float)px,(float)py);
			 	if(i==startangle)
			 	 {
			 		 //g.DrawEllipse(p,(float)x-dimx/2,(float)y-dimy/2,dimx,dimy);
			 		 g.DrawEllipse(p,(float)(rx-L),(float)(ry-T),(float)(L*2),(float)(T*2));
			 		 g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 		  cercuri[1].x = (float)x;
			 		 cercuri[1].y = (float)y;
			 		 cercuri[1].rx = (float)rx;
			 		 cercuri[1].ry = (float)ry;
			 		 cercuri[1].rot = startangle;
			 	}
			 	//g.DrawLine(p,(float)rx,(float)ry,(float)(px),(float)(py));
			 	//g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 	
			 	px = x;
			 	py = y;
			 	
			 	//Thread.Sleep(1);
			 }
			 runningison=false;
			 button1.Enabled = true;
		}
		
		public void draw3rd(int L, int T, float rx, float ry, float startangle, int dimx, int dimy)
		{
			
			 
					 
			 
			 
			 
			 double  x = L*(Math.Cos(0/rad))+rx;
			 double  y = T*(Math.Sin(0/rad))+ry;
			 
			 double px = x;
			 double py = y;
			
			 
			  	
			 for(float i = startangle ; i<360+startangle+10; i+=10)
			 {
			 	
			 	//g.Clear(Color.White);
			 	
			 	x = L*(Math.Cos(i/rad))+rx;
			 	y = T*(Math.Sin(i/rad))+ry;
			 
			 	//g.DrawLine(p,(float)x,(float)y,(float)px,(float)py);
			 	if(i==startangle)
			 	 {
			 		 //g.DrawEllipse(p,(float)x-dimx/2,(float)y-dimy/2,dimx,dimy);
			 		 g.DrawEllipse(p,(float)(rx-L),(float)(ry-T),(float)(L*2),(float)(T*2));
			 		 g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 		  cercuri[2].x = (float)x;
			 		 cercuri[2].y = (float)y;
			 		 cercuri[2].rx = (float)rx;
			 		 cercuri[2].ry = (float)ry;
			 		 cercuri[2].rot = startangle;
			 	}
			 	//g.DrawLine(p,(float)rx,(float)ry,(float)(px),(float)(py));
			 	//g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 	
			 	px = x;
			 	py = y;
			 	
			 	//Thread.Sleep(1);
			 }
			 runningison=false;
			 button1.Enabled = true;
		}
		public void draw4th(int L, int T, float rx, float ry, float startangle, int dimx, int dimy)
		{
			
			 
					 
			 
			 
			 
			 double  x = L*(Math.Cos(0/rad))+rx;
			 double  y = T*(Math.Sin(0/rad))+ry;
			 
			 double px = x;
			 double py = y;
			
			 
			  	
			 for(float i = startangle ; i<360+startangle+10; i+=10)
			 {
			 	
			 	//g.Clear(Color.White);
			 	
			 	x = L*(Math.Cos(i/rad))+rx;
			 	y = T*(Math.Sin(i/rad))+ry;
			 
			 	//g.DrawLine(p,(float)x,(float)y,(float)px,(float)py);
			 	if(i==startangle)
			 	 {
			 		 //g.DrawEllipse(p,(float)x-dimx/2,(float)y-dimy/2,dimx,dimy);
			 		 g.DrawEllipse(p,(float)(rx-L),(float)(ry-T),(float)(L*2),(float)(T*2));
			 		 g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 		  cercuri[3].x = (float)x;
			 		 cercuri[3].y = (float)y;
			 		 cercuri[3].rx = (float)rx;
			 		 cercuri[3].ry = (float)ry;
			 		 cercuri[3].rot = startangle;
			 	}
			 	//g.DrawLine(p,(float)rx,(float)ry,(float)(px),(float)(py));
			 	//g.DrawLine(p,(float)x,(float)y,(float)rx,(float)ry);
			 	
			 	px = x;
			 	py = y;
			 	
			 	//Thread.Sleep(1);
			 }
			 runningison=false;
			 button1.Enabled = true;
		}
		public void runh12()
		{
			if(runningison == false){
				float dim = 360/12;
			 for(float i = 0.0f ; i<360+dim; i+=dim)
			 {
			 	runningison = true;
			 	button1.Enabled=false;
			 
			 	//w,h,x,y
			 	draw(250,250,300,300,(int)(i),50,50);
			
				//g.Clear(Color.White);
				
			
			 }
			}
		}
		
		public void runOneTime()
		{
			if(runningison == false){
				float dim = 360/1;
			 for(float i = 0.0f ; i<360+dim; i+=dim)
			 {
			 	runningison = true;
			 	button1.Enabled=false;
			 
			 	//w,h,x,y
			 	//draw(250,250,300,300,(int)(i),250,250);
			 	draw(250,250,300,300,(int)(180),250,250);
			
				//g.Clear(Color.White);
				
			
			 }
			}
		}
		public void rotateCircle(int unghi)
		{
			if(runningison == false){
				float dim = 360/1;
			 for(float i = 0.0f ; i<360+dim; i+=dim)
			 {
			 	runningison = true;
			 	button1.Enabled=false;
			 
			 	//w,h,x,y
			 	//draw(250,250,300,300,(int)(i),250,250);
			 	draw(250,250,300,300,(int)(unghi),250,250);
			 	drawSecond(100,100,(int)cercuri[0].x,(int)cercuri[0].y,(int)(unghi+(int)cercuri[0].rot),50,50);
			 	draw3rd(50,50,(int)cercuri[1].x,(int)cercuri[1].y,(int)(unghi+(int)cercuri[1].rot),25,25);
			 	draw3rd(25,25,(int)cercuri[2].x,(int)cercuri[2].y,(int)(unghi+(int)cercuri[2].rot),15,15);
			 	
			
				//g.Clear(Color.White);
				
			
			 }
			}
		}
		public void rotatingCircleAnimation()
		{
			
			 for(float i = 0.0f ; i<360+1; i+=1)
			 {
			 	g.Clear(Color.White);
							
			 	rotateCircle((int)i);
				
			 
			}
		}
		public void rotatingCircleAnimationNoErasing()
		{
			
			 for(float i = 0.0f ; i<360+1; i+=1)
			 {
			 	//g.Clear(Color.White);
							
			 	rotateCircle((int)i);
				
			 
			}
		}
			
	}
}
