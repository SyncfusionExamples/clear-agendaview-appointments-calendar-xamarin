# How to clear appointments in the AgendaView on month change in Xamarin.Forms Calendar (SfCalendar)

You can programmatically clear the selected dates and appointments in AgendaView using the ClearSelection method in Xamarin.Forms SfCalendar.

You can also refer the following article.

https://www.syncfusion.com/kb/11793/how-to-clear-appointments-in-the-agendaview-on-month-change-in-xamarin-forms-calendar

**STEP 1:** Set InlineViewMode as Agenda, and set ShowInlineEvents to true for displaying events.
``` xml
<calendar:SfCalendar x:Name="calendar"
                             ShowInlineEvents="True"
                             InlineViewMode="Agenda"
                             DataSource="{Binding Appointments}">
        <calendar:SfCalendar.BindingContext>
            <local:ViewModel/>
        </calendar:SfCalendar.BindingContext>
</calendar:SfCalendar>
```
**STEP 2:** By using the MonthChanged event in the calendar, you can call the ClearSelection method to clear selected date and its appointments in the AgendaView.
``` c#
private void Calendar_MonthChanged(object sender, MonthChangedEventArgs e)
{
            this.calendar.ClearSelection();
}
```
**Output**

![ClearAgendaViewData](https://github.com/SyncfusionExamples/clear-agendaview-appointments-calendar-xamarin/blob/master/ScreenShot/ClearAgendaViewData.gif)
