# DoctorPatientSystem
Basic doctor and patient service system.


AlertDialog - simple dialog window. Set the message content by passing a string to the constructor. For example:
<br/><code>new AlertDialog("This string shows up in the alert.").ShowDialog();</code>
 
ConfirmationPopup - simple dialog window with two options (Confirm or Cancel). Set contents with constructor like:
</br><code>new ConfirmationPopup("This is the primary text", "This is the secondary text").ShowDialog();</code></br>
You can perform different actions based on which button in ConfirmationPopup is clicked using the DialogResult:
<br/><code>DialogResult dr = new DialogResult();
 dr = new ConfirmationPopup("PrimaryText", "SecondaryText").ShowDialog();
 if (dr == DialogResult.OK) {
     //If Confirm button was clicked, do related actions here
 }
 else if (dr == DialogResult.Cancel) {
     //If Cancel button was clicked, do related actions here, if needed
 }</code>


PatientMenu - displays all tasks available to the Patient user
