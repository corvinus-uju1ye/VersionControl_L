﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week08ToyFactory.Abstractions;
using week08ToyFactory.Entities;

namespace week08ToyFactory
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        Toy _nextToy;

        private IToyFactory _toyFactory;
        public IToyFactory ToyFactory
        {
            get { return _toyFactory; }
            set
            { 
                _toyFactory = value;
                DisplayNext();
            }
        }

        public Form1()
        {
            InitializeComponent();
            ToyFactory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = ToyFactory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;

            foreach (var ball in _toys)
            {
                ball.MoveToy();
                if (ball.Left > maxPosition)
                    maxPosition = ball.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            ToyFactory = new CarFactory();
        }

        private void buttonBall_Click(object sender, EventArgs e)
        {
            ToyFactory = new BallFactory
            {
                BallColor = buttonColor.BackColor
            };
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = ToyFactory.CreateNew();
            _nextToy.Top = labelNext.Top + labelNext.Height + 20;
            _nextToy.Left = labelNext.Left;
            Controls.Add(_nextToy);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }
    }
}
