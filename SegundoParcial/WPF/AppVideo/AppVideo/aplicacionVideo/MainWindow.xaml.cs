﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace aplicacionVideo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Un temporizador que se integra en el Dispatcher cola que se procesa en un intervalo de tiempo especificado y con una prioridad especificada.
            DispatcherTimer timer = new DispatcherTimer();
            //Obtiene o establece el período de tiempo entre los pasos del temporizador.
            timer.Interval = TimeSpan.FromSeconds(1);
            //Se produce cuando ha transcurrido el intervalo del temporizador.
            timer.Tick += timer_tick;
            //Inicia DispatcherTimer.
            timer.Start();
        }

        void timer_tick(Object sender, EventArgs e)
        {
            if (miVideo.Source != null)
            {
                if (miVideo.NaturalDuration.HasTimeSpan)
                    lbTiempo.Content = String.Format("{0} / {1}", miVideo.Position.ToString(@"mm\ss"), miVideo.NaturalDuration.TimeSpan.ToString(@"mm\ss"));
            }
            else
                lbTiempo.Content = "Película no encontrada";

        }

        private void btPlay_Click(object sender, RoutedEventArgs e)
        {
            miVideo.Play();
        }

        private void btPausa_Click(object sender, RoutedEventArgs e)
        {
            miVideo.Pause();
        }

        private void btStop_Click(object sender, RoutedEventArgs e)
        {
            miVideo.Stop();
        }
    }
}
