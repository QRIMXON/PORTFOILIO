using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public interface ICard : IComparable<ICard>
    {
        void ShowCard(PictureBox picture, Label label);

        string Name
        {
            get;
        }
        System.Drawing.Image Image
        {
            get;
        }
        double Value
        {
            get;
        }

    }
}
