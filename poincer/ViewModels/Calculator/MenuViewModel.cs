using System;
using System.Collections.Generic;
using System.Reflection;
using poincer.Views;
using PropointsView = poincer.Views.Calculator.PropointsView;

namespace poincer.ViewModels.Calculator
{
    public class MenuViewModel
    {
        public List<MyMenuItem> Menu { get; private set; }=new List<MyMenuItem>
        {
            new MyMenuItem
            {
                Title = "Propoints",
                TargetType = typeof(PropointsView)
            },
            new MyMenuItem
            {
                Title = "Propoints 2",
                TargetType = typeof(Propoints2View)
            }
        };
    }

    public class MyMenuItem
    {
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}