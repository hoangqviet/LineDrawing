﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LineDrawing {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) {

        }

        private void Window_MouseMove(object sender, MouseEventArgs e) {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {

        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) {
            polyline.Points.Add(e.GetPosition(canvas));
        }

    }
}
