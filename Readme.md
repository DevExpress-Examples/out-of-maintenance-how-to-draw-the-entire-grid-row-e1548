<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q210958/Form1.cs) (VB: [Form1.vb](./VB/Q210958/Form1.vb))
* [Program.cs](./CS/Q210958/Program.cs) (VB: [Program.vb](./VB/Q210958/Program.vb))
<!-- default file list end -->
# How to draw the entire grid row


<p>The XtraGrid draws each data cell separately. That is why it provides only the CustomDrawCell event. However, it's possible to draw the entire row using a certain brush within the CustomDrawCell event handler by calculating row bounds using view info.</p>

<br/>


