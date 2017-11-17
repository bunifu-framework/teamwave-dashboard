Imports Bunifu.DataViz
Imports Bunifu.Framework.UI

Public Class Form1

    Sub MoveIndicator(ByVal sender As Object)

        ' These will reset the colors in the labelled texts to normal for every clicked navigation label.
        ' Note however, this will not interfere with the color applied to the clicked label...
        BunifuCustomLabel14.ForeColor = Color.DimGray
        BunifuCustomLabel15.ForeColor = Color.DimGray
        BunifuCustomLabel16.ForeColor = Color.DimGray
        BunifuCustomLabel17.ForeColor = Color.DimGray
        BunifuCustomLabel18.ForeColor = Color.DimGray

        ' Convert the object clicked to a label for easier access to its properties.
        Dim clicked_label As Bunifu.Framework.UI.BunifuCustomLabel = CType(sender, Bunifu.Framework.UI.BunifuCustomLabel)

        ' Set the location of the separator (horizontally) to be below the clicked label.
        BunifuSeparator6.Location = New Point(clicked_label.Location.X, BunifuSeparator6.Location.Y)

        ' Set the width of the separator to be equal to the clicked label's width.
        BunifuSeparator6.Width = clicked_label.Width

        ' Set the fore color of the clicked label to be equal to the separator's color.
        clicked_label.ForeColor = Color.FromArgb(132, 171, 204)

    End Sub

    Sub GenerateSpline()

        ' Create a new canvas for rendering our chart.
        Dim canvas1 As New Canvas

        ' Create the first spline chart datapoints-set.
        Dim datapoint_1 As New DataPoint(BunifuDataViz._type.Bunifu_spline)

        ' Add all the datapoints for the first spline chart.
        datapoint_1.addLabely("", "27")
        datapoint_1.addLabely("", "35")
        datapoint_1.addLabely("", "20")
        datapoint_1.addLabely("", "35")
        datapoint_1.addLabely("", "20")
        datapoint_1.addLabely("", "60")
        datapoint_1.addLabely("", "50")
        datapoint_1.addLabely("", "57")
        datapoint_1.addLabely("", "40")
        datapoint_1.addLabely("", "45")

        ' Now add the datapoints-set to the canvas created.
        canvas1.addData(datapoint_1)

        ' Create the second spline chart datapoints-set.
        Dim datapoint_2 As New DataPoint(BunifuDataViz._type.Bunifu_spline)

        ' Add all the datapoints for the second spline chart.
        datapoint_2.addLabely("", "30")
        datapoint_2.addLabely("", "40")
        datapoint_2.addLabely("", "60")
        datapoint_2.addLabely("", "20")
        datapoint_2.addLabely("", "80")
        datapoint_2.addLabely("", "20")
        datapoint_2.addLabely("", "20")
        datapoint_2.addLabely("", "50")
        datapoint_2.addLabely("", "60")
        datapoint_2.addLabely("", "50")

        ' Add the datapoints-set to our canvas.
        canvas1.addData(datapoint_2)

        ' Create the third spline chart datapoints-set.
        Dim datapoint_3 As New DataPoint(BunifuDataViz._type.Bunifu_spline)

        ' Add all the datapoints for the third spline chart.
        datapoint_3.addLabely("", "80")
        datapoint_3.addLabely("", "35")
        datapoint_3.addLabely("", "20")
        datapoint_3.addLabely("", "25")
        datapoint_3.addLabely("", "20")
        datapoint_3.addLabely("", "40")
        datapoint_3.addLabely("", "20")
        datapoint_3.addLabely("", "25")
        datapoint_3.addLabely("", "40")
        datapoint_3.addLabely("", "50")

        ' Add the datapoints-set to our canvas.
        canvas1.addData(datapoint_3)

        ' Finally include the canvas created to a Dataviz component for rendering.
        BunifuDataViz1.Render(canvas1)

    End Sub

    Private Sub BunifuCustomLabel14_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel17.Click, BunifuCustomLabel16.Click, BunifuCustomLabel15.Click, BunifuCustomLabel14.Click

        ' This will move the indicator to the specific label's location when clicked.
        MoveIndicator(sender)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ' Call the method "GenerateSpline()".
        GenerateSpline()

        ' Then, once the chart has been rendered, stop the timer.
        Timer1.Stop()

        ' This will ensure that the chart has been generated only after the form has been loaded at runtime.
        ' Also, it assists in isolating the chart-rendering event and the form-loading process, since it 
        ' initializes the chart-rendering after 100 Milliseconds...
        ' Also ensure that your timer is enabled; likewise, you can also set a number of milliseconds more if required.

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Let us now add the code for coloring the Charts.
        ' Add a colorset for beautifying our charts.
        BunifuDataViz1.colorSet.Add(Color.FromArgb(60, 158, 241))
        BunifuDataViz1.colorSet.Add(Color.FromArgb(39, 180, 109))
        BunifuDataViz1.colorSet.Add(Color.FromArgb(255, 60, 49))

        ' This means that our three spline charts will be applied to the above
        ' colors in respective order.

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton9.Click, BunifuImageButton8.Click, BunifuImageButton7.Click, BunifuImageButton6.Click, BunifuImageButton5.Click, BunifuImageButton4.Click, BunifuImageButton3.Click, BunifuImageButton2.Click, BunifuImageButton10.Click

        ' We want to allow the separator to move to where the clicked BunifuImageButton lies.
        ' This will involve only the vertical movement and not the horizontal one, therefore,
        ' "Location.X" property of the Image Buttons will be used here...

        ' Let's then first start by converting the clicked object to a BunifuImageButton in order
        ' to get the list of properties within it, then after access the Location property.
        Dim clicked_image_button As BunifuImageButton = CType(sender, BunifuImageButton)

        ' Then, let's now get the location of the clicked image button's Y axis point in the form.
        Dim location_y As Integer = clicked_image_button.Location.Y

        ' Now, let's position the BunifuSeparator to the Y position of our clicked image button...
        BunifuSeparator1.Location = New Point(BunifuSeparator1.Location.X, location_y)

        ' And that's just about it!

    End Sub

End Class
