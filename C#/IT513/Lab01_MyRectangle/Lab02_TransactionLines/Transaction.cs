using System;
using System.Collections.Generic;
using System.Text;

namespace Lab02_TransactionLines
{
    internal class Transaction
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double cost;

		public double Cost
		{
			get { return cost; }
			set { cost = value; }
		}

		private int quantity;

		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}

        public Transaction(string name, double cost, int quantity)
        {
			Cost = cost;
			Name = name;
			Quantity = quantity;
        }

		public double CalcTotal()
		{
			return cost * quantity;
		}

        public override string ToString()
        {
			return $"{name} x {quantity} @ ${cost:0.00} Total: ${cost*quantity:0.00}";
        }


    }
}
