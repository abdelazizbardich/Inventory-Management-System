﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryBusinessLayer;
using System.Diagnostics;

namespace InventoryManagementSystem.Features.SearchTab
{
    public partial class SearchContent : UserControl
    {
        public SearchContent()
        {
            InitializeComponent();
        }

        private void AddFilter_Click(object sender, EventArgs e)
        {

            //SearchBL.PopulateGrid(ResultView);

            //SearchBL.GetAProductGroup(ResultView, "Name", "=", "SS Printer");

            //SearchBL.GetResult(ResultView, "TProductGroup", "Name", "SS Printer");

            FilterPanel.Controls.Add(new Filter());
        }
    }
}
