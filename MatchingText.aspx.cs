using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MatchingText
{
    public partial class MatchingText : System.Web.UI.Page
    {
       
        protected void btnMatchText_Click(Object sender, EventArgs e)
        {
          string OutPut= Process(TextBox1.Text.ToString() , TextBox2.Text.ToString());
            Label1.Text = OutPut;
        }

        public string Process( string MainText, string SubText)
        {
            //Check if MainText is longer than the subText
            string _result = "";

            if (MainText.Length < SubText.Length || SubText.Length == 0 || MainText.Length == 0)
                return "<no matches>";

            char[] _mainTextC = MainText.ToUpper().ToCharArray();
            char[] _subTextC = SubText.ToUpper().ToCharArray();

            for (int i = 0; i <= MainText.Length - 1; i++)
            {
                if (_mainTextC[i] == _subTextC[0] && i + (_subTextC.Length - 1) <= _mainTextC.Length - 1)
                {
                    int _isMatch = 1;
                    int _location = i; //get match location

                    for (int ii = 0; ii <= _subTextC.Length - 1; ii++)
                    {
                        if (_mainTextC[i + ii] != _subTextC[ii])
                        {
                            _isMatch = _isMatch * -1;
                            i = _location + ii; //set new location to start
                            ii = _subTextC.Length - 1; // end current loop
                        }
                    }

                    if (_isMatch == 1)
                    {
                        _result += _result.Length == 0 ? (_location + 1).ToString() : "," + (_location + 1).ToString();
                        i += _subTextC.Length - 1;//set new location to start
                    }
                }
            }

            return _result.Length == 0 ? "<no matches>" : _result;
        }


    }
}