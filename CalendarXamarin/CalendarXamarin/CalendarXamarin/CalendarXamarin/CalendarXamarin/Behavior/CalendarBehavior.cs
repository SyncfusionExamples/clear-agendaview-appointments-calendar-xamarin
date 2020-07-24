using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin.Behavior
{
    class CalendarBehavior : Behavior<ContentPage>
    {
        SfCalendar calendar;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.calendar = bindable.FindByName<SfCalendar>("calendar");
            this.WireEvents();
        }

        private void WireEvents()
        {
            this.calendar.MonthChanged += Calendar_MonthChanged;
        }

        private void Calendar_MonthChanged(object sender, MonthChangedEventArgs e)
        {
            this.calendar.ClearSelection();
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            this.UnWireEvents();
        }

        private void UnWireEvents()
        {
            this.calendar.MonthChanged -= Calendar_MonthChanged;
        }
    }
}
