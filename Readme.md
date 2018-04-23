# How to draw the entire grid row


<p>The XtraGrid draws each data cell separately. That is why it provides only the CustomDrawCell event. However, it's possible to draw the entire row using a certain brush within the CustomDrawCell event handler by calculating row bounds using view info.</p>

<br/>


