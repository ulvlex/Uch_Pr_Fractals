using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBlock
{
    public class Node
    {
        private Point _coordT;
        private Point _coordF;

        private Node? _First;
        private Node? _Second;
        private Node? _Third;
        private Node? _Fourth;
        private Node? _Fifth;
        private Node? _Sixth;
        private Node? _Parent;
        
        private double _Angle;

        private int _Level;

        public int Level 
        {
            get { return this._Level; }
            set { this._Level = value; }
        }

        public Point coordT
        {
            get { return this._coordT; }
            set { this._coordT = value; }
        }

        public Point coordF
        {
            get { return this._coordF; }
            set { this._coordF = value; }
        }

        public double Angle
        {
            get { return this._Angle; }
            set { this._Angle = value; }
        }
      
        public Node? First
        {
            get { return this._First; }
            set { this._First = value; }
        }
        public Node? Second
        {
            get { return this._Second; }
            set { this._Second = value; }
        }
        public Node? Third
        {
            get { return this._Third; }
            set { this._Third = value; }
        }
        public Node? Fourth
        {
            get { return this._Fourth; }
            set { this._Fourth = value; }
        }
        public Node? Fifth
        {
            get { return this._Fifth; }
            set { this._Fifth = value; }
        }

        public Node? Sixth
        {
            get { return this._Sixth; }
            set { this._Sixth = value; }
        }
        public Node? Parent
        {
            get { return this._Parent; }
            set { this._Parent = value; }
        }

		public Node(Point tree, Point fract, int level, double Angle) { 
			this._coordT = tree;
			this._coordF = fract;
			this._Level = level;
			this._Angle = Angle;
		}
     

    }
    class Tree
    {

  
		public Node? root;

        const int numLevel  = 10;
		const int dEllipse = 10;
		public int side;

        private int[] numElOfLvl;

        public Node[] lvl1;
        public Node[] lvl2;
        public Node[] lvl3;
        public Node[] lvl4;
        public Node[] lvl5;
        public Node[] lvl6;
        public Node[] lvl7;
        public Node[] lvl8;
        public Node[] lvl9;

        Pen pen = new Pen(Color.Red);
        Brush brush;

        public Tree(int SideSize)
        {

            numElOfLvl = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };            
            side = SideSize;
			root = null;
			lvl1 = new Node[6];
			lvl2 = new Node[18];
			lvl3 = new Node[54];
			lvl4 = new Node[162];
			lvl5 = new Node[486];
			lvl6 = new Node[1458];
			lvl7 = new Node[4374];
			lvl8 = new Node[13122];
			lvl9 = new Node[39366];
		}

        private void AddLevel(int numOfLevel, int _width, int _height)
        {
            Point tree;
            Point fract;
            int _Level;
            double _angle;
          

            switch (numOfLevel)
            {
                case 0: break;
                case 1: AddChildren(root, _width, _height); break;
                case 2:
                    for (int i = 0; i < 6; i++)
                    {
                        AddChildren(lvl1[i], _width, _height);
                    }
                    break;
                case 3:
                    for (int i = 0; i < 18; i++)
                    {
                        AddChildren(lvl2[i], _width, _height);
                    }
                    break;
                case 4:
                    for (int i = 0; i < 54; i++)
                    {
                        AddChildren(lvl3[i], _width, _height);
                    }
                    break;
                case 5:
                    for (int i = 0; i < 162; i++)
                    {
                        AddChildren(lvl4[i], _width, _height);
                    }
                    break;
                case 6:
                    for (int i = 0; i < 486; i++)
                    {
                        AddChildren(lvl5[i], _width, _height);
                    }
                    break;
                case 7:
                    for (int i = 0; i < 1458; i++)
                    {
                        AddChildren(lvl6[i], _width, _height);
                    }
                    break;
                case 8:
                    for (int i = 0; i < 4374; i++)
                    {
                        AddChildren(lvl7[i], _width, _height);
                    }
                    break;
                case 9:
                    for (int i = 0; i < 13122; i++)
                    {
                        AddChildren(lvl8[i], _width, _height);
                    }
                    break;
            }

        }

		private void AddChildren(Node _parent, int _width, int _height)
		{
			Point tree;
			Point fract;
			int _Level;
			double _angle;

			int xT, yT, xF, yF;

			if (_parent.Level+1 == 1)
			{
				//First Child
				xF = (int)Math.Round(_parent.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(0.52));
				yF = (int)Math.Round(_parent.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(0.52));

				xT = 3*_width /(2 * numLevel);
				yT = _height / 12;

				tree = new Point(xT, yT);
				fract = new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = 0.52; // 30
				Node newFirstNode = new Node(tree, fract, _Level, _angle);
				newFirstNode.First = null;
				newFirstNode.Second = null;
				newFirstNode.Third = null;
				newFirstNode.Fourth = null;
				newFirstNode.Fifth = null;
				newFirstNode.Sixth = null;
				newFirstNode.Parent = _parent;
				_parent.First = newFirstNode;
				numElOfLvl[_parent.Level + 1]++;//NEW!!

				//Second Child
				xF = (int)Math.Round(_parent.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(1.57));
				yF = (int)Math.Round(_parent.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(1.57));

				xT = 3 * _width / (2 * numLevel);
				yT = 3 * _height / 12;

				tree = new Point(xT, yT);
				fract = new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = 1.57; // 90
				Node newSecondNode = new Node(tree, fract, _Level, _angle);
				newSecondNode.First = null;
				newSecondNode.Second = null;
				newSecondNode.Third = null;
				newSecondNode.Fourth = null;
				newSecondNode.Fifth = null;
				newSecondNode.Sixth = null;
				newSecondNode.Parent = _parent;
				_parent.Second = newSecondNode;
				numElOfLvl[_parent.Level + 1]++;//NEW!!

				//Third Child
				xF = (int)Math.Round(_parent.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(2.62));
				yF = (int)Math.Round(_parent.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(2.62));

				xT = 3 * _width / (2 * numLevel);
				yT = 5 * _height / 12;

				tree = new Point(xT, yT);
				fract = new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = 2.62; // 150
				Node newThirdNode = new Node(tree, fract, _Level, _angle);
				newThirdNode.First = null;
				newThirdNode.Second = null;
				newThirdNode.Third = null;
				newThirdNode.Fourth = null;
				newThirdNode.Fifth = null;
				newThirdNode.Sixth = null;
				newThirdNode.Parent = _parent;
				_parent.Third = newThirdNode;
				numElOfLvl[_parent.Level + 1]++;//NEW!!

				//Fourth Child
				xF = (int)Math.Round(_parent.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(3.67));
				yF = (int)Math.Round(_parent.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(3.67));

				xT = 3 * _width / (2 * numLevel);
				yT = 7 * _height / 12;

				tree = new Point(xT, yT);
				fract = new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = 3.67; // 210
				Node newFourthNode = new Node(tree, fract, _Level, _angle);
				newFourthNode.First = null;
				newFourthNode.Second = null;
				newFourthNode.Third = null;
				newFourthNode.Fourth = null;
				newFourthNode.Fifth = null;
				newFourthNode.Sixth = null;
				newFourthNode.Parent = _parent;
				_parent.Fourth = newFourthNode;
				numElOfLvl[_parent.Level + 1]++;//NEW!!
				

				//Fifth Child
				xF = (int)Math.Round(_parent.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(4.71));
				yF = (int)Math.Round(_parent.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(4.71));

				xT = 3 * _width / (2 * numLevel);
				yT = 9 * _height / 12;

				tree = new Point(xT, yT);
				fract = new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = 4.71; // 270
				Node newFifthNode = new Node(tree, fract, _Level, _angle);
				newFifthNode.First = null;
				newFifthNode.Second = null;
				newFifthNode.Third = null;
				newFifthNode.Fourth = null;
				newFifthNode.Fifth = null;
				newFifthNode.Sixth = null;
				newFifthNode.Parent = _parent;
				_parent.Fifth = newFifthNode;
				numElOfLvl[_parent.Level + 1]++;//NEW!!

				//Sixth CHild
				xF = (int)Math.Round(_parent.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(5.76));
				yF = (int)Math.Round( _parent.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(5.76));

				xT = 3 * _width / (2 * numLevel);
				yT = 11 * _height / 12;

				tree =new  Point(xT, yT);
				fract =new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = 5.76; // 330
				Node newSixthNode = new Node(tree, fract, _Level, _angle);
				newSixthNode.First = null;
				newSixthNode.Second = null;
				newSixthNode.Third = null;
				newSixthNode.Fourth = null;
				newSixthNode.Fifth = null;
				newSixthNode.Sixth = null;
				newSixthNode.Parent = _parent;
				_parent.Sixth = newSixthNode;
				numElOfLvl[_parent.Level + 1]++;//NEW!!

				//NEW!!!NEW!!NEW!!
				//Adding new element to our Arrays
				lvl1[0] = _parent.First;
				lvl1[1] = _parent.Second;
				lvl1[2] = _parent.Third;
				lvl1[3] = _parent.Fourth;
				lvl1[4] = _parent.Fifth;
				lvl1[5] = _parent.Sixth;
			}

			if (_parent.Level+1 > 1)
			{
				int tempSide = (int)Math.Round(side / Math.Pow(3, _parent.Level));
				int tempX = (int)Math.Round(_parent.coordF.X + Math.Sqrt(3) / 6 * tempSide * Math.Cos(_parent.Angle));
				int tempY = (int)Math.Round(_parent.coordF.Y - Math.Sqrt(3) / 6 * tempSide * Math.Sin(_parent.Angle));

				int parentHeight = _height / (numElOfLvl[_parent.Level]);
				int step = (parentHeight - 3 * dEllipse) / 6;

				//First Child
				xF = (int)Math.Round(tempX + Math.Sqrt(3) * tempSide / 6 * Math.Cos(-1.05 + _parent.Angle));
				yF = (int)Math.Round(tempY - Math.Sqrt(3) * tempSide / 6 * Math.Sin(-1.05 + _parent.Angle));

				xT = _parent.coordT.X + 2*_width / (2 * numLevel);
				yT = _parent.coordT.Y - 2 * step - dEllipse;

				tree =new Point(xT, yT);
				fract =new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = -1.05 + _parent.Angle; // 30
				Node newFirstNode = new Node(tree, fract, _Level, _angle);
				newFirstNode.First = null;
				newFirstNode.Second = null;
				newFirstNode.Third = null;
				newFirstNode.Fourth = null;
				newFirstNode.Fifth = null;
				newFirstNode.Sixth = null;
				newFirstNode.Parent = _parent;
				_parent.First = newFirstNode;
				numElOfLvl[_parent.Level+1]++;//NEW!!

				//Second Child
				xF = (int)Math.Round(tempX + Math.Sqrt(3) * tempSide / 6 * Math.Cos(_parent.Angle));
				yF = (int)Math.Round(tempY - Math.Sqrt(3) * tempSide / 6 * Math.Sin(_parent.Angle));

				xT = _parent.coordT.X+ 2*_width / (2 * numLevel);
				yT = _parent.coordT.Y ;

				tree =new  Point(xT, yT);
				fract =new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = _parent.Angle; // 
				Node newSecondNode = new Node(tree, fract, _Level, _angle);
				newSecondNode.First = null;
				newSecondNode.Second = null;
				newSecondNode.Third = null;
				newSecondNode.Fourth = null;
				newSecondNode.Fifth = null;
				newSecondNode.Sixth = null;
				newSecondNode.Parent = _parent;
				_parent.Second = newSecondNode;
				numElOfLvl[_parent.Level+1]++;//NEW!!

				//Third Child
				xF = (int)Math.Round(tempX + Math.Sqrt(3) * tempSide / 6 * Math.Cos(1.05 + _parent.Angle));
				yF = (int)Math.Round(tempY - Math.Sqrt(3) * tempSide / 6 * Math.Sin(1.05 + _parent.Angle));

				xT = _parent.coordT.X + 2*_width / (2 * numLevel);
				yT = _parent.coordT.Y + 2 * step + dEllipse;

				tree =new Point(xT, yT);
				fract =new Point(xF, yF);
				_Level = _parent.Level + 1;
				_angle = 1.05 + _parent.Angle; // 30
				Node newThirdNode = new Node(tree, fract, _Level, _angle);
				newThirdNode.First = null;
				newThirdNode.Second = null;
				newThirdNode.Third = null;
				newThirdNode.Fourth = null;
				newThirdNode.Fifth = null;
				newThirdNode.Sixth = null;
				newThirdNode.Parent = _parent;
				_parent.Third = newThirdNode;
				numElOfLvl[_parent.Level+1]++;//NEW!!
				
				//NEW!!!NEW!!NEW!!
				//Adding new element to our Arrays
				
				switch (_parent.Level + 1) {
                    case 2:
						lvl2[numElOfLvl[_parent.Level+1]- 3] = _parent.First;
						lvl2[numElOfLvl[_parent.Level+1] -2] = _parent.Second;
						lvl2[numElOfLvl[_parent.Level+1] -1] = _parent.Third;
						break;
					case 3:
						lvl3[numElOfLvl[_parent.Level + 1] - 3] = _parent.First;
						lvl3[numElOfLvl[_parent.Level + 1] - 2] = _parent.Second;
						lvl3[numElOfLvl[_parent.Level + 1] - 1] = _parent.Third;
						break;
					case 4:
						lvl4[numElOfLvl[_parent.Level + 1] - 3] = _parent.First;
						lvl4[numElOfLvl[_parent.Level + 1] - 2] = _parent.Second;
						lvl4[numElOfLvl[_parent.Level + 1] - 1] = _parent.Third;
						break;
					case 5:
						lvl5[numElOfLvl[_parent.Level + 1] - 3] = _parent.First;
						lvl5[numElOfLvl[_parent.Level + 1] - 2] = _parent.Second;
						lvl5[numElOfLvl[_parent.Level + 1] - 1] = _parent.Third;
						break;
					case 6:
						lvl6[numElOfLvl[_parent.Level + 1] - 3] = _parent.First;
						lvl6[numElOfLvl[_parent.Level + 1] - 2] = _parent.Second;
						lvl6[numElOfLvl[_parent.Level + 1] - 1] = _parent.Third;
						break;
					case 7:
						lvl7[numElOfLvl[_parent.Level + 1] - 3] = _parent.First;
						lvl7[numElOfLvl[_parent.Level + 1] - 2] = _parent.Second;
						lvl7[numElOfLvl[_parent.Level + 1] - 1] = _parent.Third;
						break;
					case 8:
						lvl8[numElOfLvl[_parent.Level + 1] - 3] = _parent.First;
						lvl8[numElOfLvl[_parent.Level + 1] - 2] = _parent.Second;
						lvl8[numElOfLvl[_parent.Level + 1] - 1] = _parent.Third;
						break;
					case 9:
						lvl9[numElOfLvl[_parent.Level + 1] - 3] = _parent.First;
						lvl9[numElOfLvl[_parent.Level + 1] - 2] = _parent.Second;
						lvl9[numElOfLvl[_parent.Level + 1] - 1] = _parent.Third;
						break;


				}
			}
					
			

		}
		public void AddNumLevel(int _level, int _width, int _height)
		{
			brush = new SolidBrush(Color.Red);
			pen.Color = Color.Red;
			Point tree;
			Point fract;
			int _Level;
			double _angle;

			int xT, yT;
			xT = _width/ (2 * numLevel);
			yT = _height / 2;
			tree = new Point(xT, yT);
			fract = new Point(0, 0);
			_Level = 0;
			_angle = 0;
			Node newNode = new Node(tree, fract, _Level, _angle);
			
			newNode.First = null;
			newNode.Second = null;
			newNode.Third = null;
			newNode.Fourth = null;
			newNode.Fifth = null;
			newNode.Sixth = null;
			newNode.Parent = null;
			root = newNode;
			
			numElOfLvl[0] = 1; //NEW!!
			for (int i = 0; i <= _level; i++)
			{
				AddLevel(i, _width, _height);
			}
		}

		void PaintTreeLayer(int numLayer, PaintEventArgs e)
		{
			switch (numLayer)
			{
				case 0:
					brush = new SolidBrush(Color.Red);
					pen.Color = Color.Red;
					e.Graphics.DrawEllipse(pen, root.coordT.X - 5, root.coordT.Y - 5, 10, 10);
					e.Graphics.FillEllipse(brush, root.coordT.X - 5, root.coordT.Y - 5, 10, 10);
                    break;
                case 1:
					brush = new SolidBrush(Color.Purple);
					pen.Color = Color.Purple;
					for (int i = 0; i < lvl1.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl1[i].coordT.X - 5, lvl1[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl1[i].coordT.X - 5, lvl1[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl1[i].coordT.X-5, lvl1[i].coordT.Y, lvl1[i].Parent.coordT.X+5, lvl1[i].Parent.coordT.Y);
					}
					break;
				case 2:
					brush = new SolidBrush(Color.DeepPink);
					pen.Color = Color.DeepPink;
					for (int i = 0; i < lvl2.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl2[i].coordT.X - 5, lvl2[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl2[i].coordT.X - 5, lvl2[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl2[i].coordT.X-5, lvl2[i].coordT.Y, lvl2[i].Parent.coordT.X+5, lvl2[i].Parent.coordT.Y);
					}
					break;
				case 3:
					brush = new SolidBrush(Color.DarkBlue);
					pen.Color = Color.DarkBlue;
					for (int i = 0; i < lvl3.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl3[i].coordT.X - 5, lvl3[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl3[i].coordT.X - 5, lvl3[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl3[i].coordT.X-5, lvl3[i].coordT.Y, lvl3[i].Parent.coordT.X+5, lvl3[i].Parent.coordT.Y);
					}
					break;
				case 4:
					brush = new SolidBrush(Color.DarkGreen);
					pen.Color = Color.DarkGreen;
					for (int i = 0; i < lvl4.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl4[i].coordT.X - 5, lvl4[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl4[i].coordT.X - 5, lvl4[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl4[i].coordT.X-5, lvl4[i].coordT.Y, lvl4[i].Parent.coordT.X+5, lvl4[i].Parent.coordT.Y);
					}
					break;
				case 5:
					brush = new SolidBrush(Color.YellowGreen);
					pen.Color = Color.YellowGreen;
					for (int i = 0; i < lvl5.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl5[i].coordT.X - 5, lvl5[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl5[i].coordT.X - 5, lvl5[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl5[i].coordT.X-5, lvl5[i].coordT.Y, lvl5[i].Parent.coordT.X+5, lvl5[i].Parent.coordT.Y);
					}
					break;
				case 6:
					brush = new SolidBrush(Color.Yellow);
					pen.Color = Color.Yellow;
					for (int i = 0; i < lvl6.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl6[i].coordT.X - 5, lvl6[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl6[i].coordT.X - 5, lvl6[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl6[i].coordT.X-5, lvl6[i].coordT.Y, lvl6[i].Parent.coordT.X+5, lvl6[i].Parent.coordT.Y);
					}
					break;
				case 7:
					brush = new SolidBrush(Color.Orange);
					pen.Color = Color.Orange;
					for (int i = 0; i < lvl7.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl7[i].coordT.X - 5, lvl7[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl7[i].coordT.X - 5, lvl7[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl7[i].coordT.X-5, lvl7[i].coordT.Y, lvl7[i].Parent.coordT.X+5, lvl7[i].Parent.coordT.Y);
					}
					break;
				case 8:
					brush = new SolidBrush(Color.Coral);
					pen.Color = Color.Coral;
					for (int i = 0; i < lvl8.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl8[i].coordT.X - 5, lvl8[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl8[i].coordT.X - 5, lvl8[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl8[i].coordT.X-5, lvl8[i].coordT.Y, lvl8[i].Parent.coordT.X+5, lvl8[i].Parent.coordT.Y);
					}
					break;
				case 9:
					brush = new SolidBrush(Color.DarkRed);
					pen.Color = Color.DarkRed;
					for (int i = 0; i < lvl9.Length; i++)
					{
						e.Graphics.DrawEllipse(pen, lvl9[i].coordT.X - 5, lvl9[i].coordT.Y - 5, 10, 10);
						e.Graphics.FillEllipse(brush, lvl9[i].coordT.X - 5, lvl9[i].coordT.Y - 5, 10, 10);
						e.Graphics.DrawLine(Pens.Black, lvl9[i].coordT.X-5, lvl9[i].coordT.Y, lvl9[i].Parent.coordT.X+5, lvl9[i].Parent.coordT.Y);
					}
					break;
			}
        }

		public void PaintTree(PaintEventArgs e)
		{
			for(int i =0; i<10;i++) PaintTreeLayer(i,e);			
			
		}

		public void PrintFractal(int numOfLayers, PaintEventArgs e)
		{
			if (numOfLayers >= 0)
			{
				PrintLevelFractal(0, e);
				if (numOfLayers >= 1)
				{
					PrintLevelFractal(1, e);
					if (numOfLayers >= 2)
					{
						PrintLevelFractal(2, e);
						if (numOfLayers >= 3)
						{
							PrintLevelFractal(3, e);
							if (numOfLayers >= 4)
							{
								PrintLevelFractal(4, e);
								if (numOfLayers >= 5)
								{
									PrintLevelFractal(5, e);
									if (numOfLayers >= 6)
									{
										PrintLevelFractal(6, e);
										if (numOfLayers >= 7)
										{
											PrintLevelFractal(7, e);
											if (numOfLayers >= 8)
											{
												PrintLevelFractal(8, e);
												if (numOfLayers >= 9)
												{
													PrintLevelFractal(9, e);

												}

											}

										}
									}

								}

							}

						}

					}

				}
			}
			
		}

		private void PrintLevelFractal(int numOfLayer, PaintEventArgs e)
		{
			if (numOfLayer == 0) 
			{
				
				pen.Width = 2;
				pen.Color = Color.Red;
				e.Graphics.DrawLine(pen,(int)Math.Round(root.Second.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(root.Second.Angle)), (int)Math.Round(root.Second.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(root.Second.Angle)), (int)Math.Round(root.Fourth.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(root.Fourth.Angle)),(int)Math.Round(root.Fourth.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(root.Fourth.Angle)));
				e.Graphics.DrawLine(pen, (int)Math.Round(root.Second.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(root.Second.Angle)), (int)Math.Round(root.Second.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(root.Second.Angle)), (int)Math.Round(root.Sixth.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(root.Sixth.Angle)),(int)Math.Round(root.Sixth.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(root.Sixth.Angle)));
				e.Graphics.DrawLine(pen, (int)Math.Round(root.Fourth.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(root.Fourth.Angle)),(int)Math.Round(root.Fourth.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(root.Fourth.Angle)), (int)Math.Round(root.Sixth.coordF.X + Math.Sqrt(3) * side / 6 * Math.Cos(root.Sixth.Angle)), (int)Math.Round(root.Sixth.coordF.Y - Math.Sqrt(3) * side / 6 * Math.Sin(root.Sixth.Angle)));
				
			}
			if (numOfLayer == 1)
			{
				for (int i = 0; i < lvl1.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, numOfLayer));
					int tempX= (int)Math.Round(lvl1[i].coordF.X+tempSide*Math.Sqrt(3)/6 * Math.Cos((lvl1[i].Angle)));
					int tempY= (int)Math.Round(lvl1[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl1[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl1[i].Angle+2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl1[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl1[i].Angle + 4.19)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl1[i].Angle) + 4.19)));
					pen.Color = Color.Purple;
					pen.Width = 2;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl1[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl1[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl1[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl1[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl1[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl1[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl1[i].Angle + 4.19)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl1[i].Angle) + 4.19)));
					
				}
			}
			if (numOfLayer == 2)
			{
				for (int i = 0; i < lvl2.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, 2));
					int tempX = (int)Math.Round(lvl2[i].coordF.X +tempSide * Math.Sqrt(3) / 6 * Math.Cos((lvl2[i].Angle)));
					int tempY = (int)Math.Round(lvl2[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl2[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl2[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl2[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl2[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl2[i].Angle) + 4.29)));
					pen.Width = 2;
					pen.Color = Color.DeepPink;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl2[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl2[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl2[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl2[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl2[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl2[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl2[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl2[i].Angle) + 4.29)));
					pen.Width = 1;
				}
			}
			if (numOfLayer == 3)
			{
				for (int i = 0; i < lvl3.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, 3));
					int tempX = (int)Math.Round(lvl3[i].coordF.X + tempSide * Math.Sqrt(3) / 6 * Math.Cos((lvl3[i].Angle)));
					int tempY = (int)Math.Round(lvl3[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl3[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl3[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl3[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl3[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl3[i].Angle) + 4.29)));
					pen.Color = Color.DarkBlue;
					pen.Width = 2;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl3[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl3[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl3[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl3[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl3[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl3[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl3[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl3[i].Angle) + 4.29)));
				}
			}
			if (numOfLayer == 4)
			{
				for (int i = 0; i < lvl4.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, 4));
					int tempX = (int)Math.Round(lvl4[i].coordF.X + tempSide * Math.Sqrt(3) / 6 * Math.Cos((lvl4[i].Angle)));
					int tempY = (int)Math.Round(lvl4[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl4[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl4[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl4[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl4[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl4[i].Angle) + 4.29)));
					pen.Width = 2;
					pen.Color = Color.DarkGreen;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl4[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl4[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl4[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl4[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl4[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl4[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl4[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl4[i].Angle) + 4.29)));
					pen.Width = 1;
				}
			}
			if (numOfLayer == 5)
			{
				for (int i = 0; i < lvl5.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, 5));
					int tempX = (int)Math.Round(lvl5[i].coordF.X + tempSide * Math.Sqrt(3) / 6 * Math.Cos((lvl5[i].Angle)));
					int tempY = (int)Math.Round(lvl5[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl5[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl5[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl5[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl5[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl5[i].Angle) + 4.29)));
					pen.Width = 2;
					pen.Color = Color.YellowGreen;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl5[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl5[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl5[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl5[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl5[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl5[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl5[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl5[i].Angle) + 4.29)));
					pen.Width = 1;
				}
			}
			if (numOfLayer == 6)
			{
				for (int i = 0; i < lvl6.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, 6));
					int tempX = (int)Math.Round(lvl6[i].coordF.X + tempSide * Math.Sqrt(3) / 6 * Math.Cos((lvl6[i].Angle)));
					int tempY = (int)Math.Round(lvl6[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl6[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl6[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl6[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl6[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl6[i].Angle) + 4.29)));
					pen.Width = 2;
					pen.Color = Color.Yellow;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl6[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl6[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl6[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl6[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl6[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl6[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl6[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl6[i].Angle) + 4.29)));
					pen.Width = 1;
				}
			}

			if (numOfLayer == 7)
			{
				for (int i = 0; i < lvl7.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, 7));
					int tempX = (int)Math.Round(lvl7[i].coordF.X + tempSide * Math.Sqrt(3) / 6 * Math.Cos((lvl7[i].Angle)));
					int tempY = (int)Math.Round(lvl7[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl7[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl7[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl7[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl7[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl7[i].Angle) + 4.29)));
					pen.Width = 2;
					pen.Color = Color.Orange;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl7[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl7[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl7[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl7[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl7[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl7[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl7[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl7[i].Angle) + 4.29)));
					pen.Width = 1;
				}
			}

			if (numOfLayer == 8)
			{
				for (int i = 0; i < lvl8.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, 8));
					int tempX = (int)Math.Round(lvl8[i].coordF.X + tempSide * Math.Sqrt(3) / 6 * Math.Cos((lvl8[i].Angle)));
					int tempY = (int)Math.Round(lvl8[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl8[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl8[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl8[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl8[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl8[i].Angle) + 4.29)));
					pen.Width = 2;
					pen.Color = Color.Coral;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl8[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl8[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl8[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl8[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl8[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl8[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl8[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl8[i].Angle) + 4.29)));
					pen.Width = 1;
				}
			}
			if (numOfLayer == 9)
			{
				for (int i = 0; i < lvl9.Length; i++)
				{
					int tempSide = (int)Math.Round(side / Math.Pow(3, 9));
					int tempX = (int)Math.Round(lvl9[i].coordF.X + tempSide * Math.Sqrt(3) / 6 * Math.Cos((lvl9[i].Angle)));
					int tempY = (int)Math.Round(lvl9[i].coordF.Y - tempSide * Math.Sqrt(3) / 6 * Math.Sin((lvl9[i].Angle)));
					pen.Color = Color.White;
					pen.Width = 10;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl9[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl9[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl9[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl9[i].Angle) + 4.29)));
					pen.Width = 2;
					pen.Color = Color.DarkRed;
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl9[i].Angle + 2.09)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl9[i].Angle) + 2.09)), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl9[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl9[i].Angle))));
					e.Graphics.DrawLine(pen, (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl9[i].Angle)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl9[i].Angle))), (int)Math.Round(tempX + tempSide * Math.Sqrt(3) / 3 * Math.Cos(-lvl9[i].Angle + 4.29)), (int)Math.Round(tempY + tempSide * Math.Sqrt(3) / 3 * Math.Sin((-lvl9[i].Angle) + 4.29)));
					pen.Width = 1;
				}
			}



		}

	}


}
