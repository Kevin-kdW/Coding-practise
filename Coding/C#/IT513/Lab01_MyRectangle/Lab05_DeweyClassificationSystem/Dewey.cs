using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_DeweyClassificationSystem
{
    internal class Dewey
    {
		private int code;

		public int Code
		{
			get { return code; }
			set { code = value; }
		}

		private string descriptor;

		public string Descriptor
		{
			get { return descriptor; }
			set { descriptor = value; }
		}

        public Dewey(int code, string descriptor)
        {
			Code = code;
			Descriptor = descriptor;
        }

        public override string ToString()
        {
			return $"{code}: {descriptor}";
        }
    }
}
