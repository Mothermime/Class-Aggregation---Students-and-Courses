﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Class_Aggregation___Students_and_Courses
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Student myStudent = new Student();
        public MainPage()
        {
            this.InitializeComponent();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            cbxStudent.Items.Add("Counselling");
            cbxStudent.Items.Add("Business");
            cbxStudent.SelectedIndex = 0; // choose one to start


        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lbxDetails.Items.Clear();
            //data going into the class
            myStudent.Firstname = txtFirstName.Text;
            myStudent.Lastname = txtLastName.Text;
            //data coming out of the class
            lbxDetails.Items.Add(myStudent.College);
            lbxDetails.Items.Add(myStudent.City);
            lbxDetails.Items.Add(myStudent.Fullname());
            txtFullname.Text = myStudent.Fullname();

            //so what did you choose Counselling or Business?
            switch (cbxStudent.SelectedIndex)
            {
                case 0: // Counselling         
                    lbxDetails.Items.Add(myStudent.counselling.Room);
                    lbxDetails.Items.Add(myStudent.counselling.Toy);
                    break;
                case 1: //Business                
                    lbxDetails.Items.Add(myStudent.business.Field);
                    lbxDetails.Items.Add(myStudent.business.Room);
                    break; 
            }

        }
    }
}
