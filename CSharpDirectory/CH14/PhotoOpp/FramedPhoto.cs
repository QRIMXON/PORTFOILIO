using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public enum Material
    {
        PINE = 0,
        OAK = 1,
        STEEL = 2,
        SILVER = 3,
        GOLD = 4
    }

    public enum Style
    {
        SIMPLE = 0,
        MODERN = 1,
        ANTIQUE = 2,
        VINTAGE = 3,
        ECLECTIC = 4
    }

            public class FramedPhoto : Photo
            {
                protected Material _material;
                protected Style _style;

                public FramedPhoto(float width, float height, Material material, Style style) : base(width, height)
                {
                    _material = material;
                    _style = style;
                }
                public Material Material
                {
                    set { _material = value; }
                    get { return _material; }
                }
                public Style Style
                {
                    set { _style = value; }
                    get { return _style; }
                }
                public override string ToString()
                {
                    return $"{_width}x{_height}, {Price}, {_material}, {_style}";
                }
                public override double Price { get => base.Price + 25; }
            }
        }
    
