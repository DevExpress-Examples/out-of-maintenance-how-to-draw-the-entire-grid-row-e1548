<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1548)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q210958/Form1.cs) (VB: [Form1.vb](./VB/Q210958/Form1.vb))
<!-- default file list end -->
# How to draw the entire grid row


<p>The XtraGrid draws each data cell separately. That is why it provides only the CustomDrawCell event. However, it's possible to draw the entire row using a certain brush within the CustomDrawCell event handler by calculating row bounds using view info.</p>

<br/>


