﻿using grapher.Models.Serialized;

namespace grapher.Layouts
{
    public class NaturalLayout : LayoutBase
    {
        public NaturalLayout()
            : base()
        {
            Name = "Natural";
            Index = (int)AccelMode.natural;
            LogarithmicCharts = false;

            AccelLayout = new OptionLayout(true, Acceleration);
            OffsetLayout = new OptionLayout(true, Offset);
            LimitLayout = new OptionLayout(true, Limit);
        }
    }
}
