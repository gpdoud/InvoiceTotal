﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal {
    public partial class InvoiceTotalForm : Form {
        public InvoiceTotalForm() {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            if(txtSubtotal.Text == "") {
                MessageBox.Show("Subtotal is required", "Error Entry");
                return;
            }
            decimal subtotal = 0;
            try {
                subtotal = Convert.ToDecimal(txtSubtotal.Text);
            } catch {
                MessageBox.Show("Subtotal must be numeric", "Error Entry");
                return;
            }
            decimal discountPercent = .2m;               
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
