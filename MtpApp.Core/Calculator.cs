using System;
using System.Collections.Generic;

namespace MtpApp.Core
{
    public class Calculator
    {
        private int _total = 0;
        private List<int> _saveinput ;
        private Boolean _abs;

        public Calculator()
        {
            _abs = false;
            _saveinput = new List<int>();
        }

        public Calculator(bool abs)
        {
            _abs = abs;
            _saveinput = new List<int>();

        }

        public void SetAbs(bool abs)
        {
            _abs = abs;
        }


        public void Input(int a)
        {
            if (_abs == true)
            {
                a = Math.Abs(a);
            }
            _total += a;
            _saveinput.Add(a);
            
        }

        public int GetResult()
        {
            return _total;
        }

        public List<int> GetHistory()
        {
            return _saveinput;
        }

       
    }

    
}
