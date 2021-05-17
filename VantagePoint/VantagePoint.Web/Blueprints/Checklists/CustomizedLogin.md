
Check-list to customize Login-panel: Background slides/effects, Welcome text and Logo


1. Updating Welcome Text in Login Panel
- Search for "Text.cs" in Solution Explorer
- Find the "Login" class
- Update the text on "FormTitle" or any other property that you need

2. Updating Background images in Login Panel (slides)
- Search for "BuildupSDK.Web.js" in Solution Explorer
- Find the "LoginPanel" function
- Adjust the "delay" parameter to change the waiting time for the nexte slide at login (numbers in miliseconds)
- Change the "overlay" image (encoded in base64) to adjust the filter over the background slides.
  You can also make it "false" (boolean literal, not string) and comment out the base64 image to remove the overlay effect
- Change the image URL under "slides" to use your own. You can add as many additional slides as you want (comma separated)
- Change the "transition" effect on the slides as you like

3. Updating the Logo in Login Panel
- Search for "AccountLogin.cshtml" in Solution Explorer
- Find the "#LoginPanel .logo" css-class
- Change the "background" to use your own base64-encoded image 


Foot-notes: 
- This customization is already applied in this project so you can look at the files above to have a better idea of the final result.
- The slide-show and effects are based on a library called Vegas. You can find more information on their website: https://vegas.jaysalvat.com/
- To produce a base64-encoded image when you have a .jpeg or any other file format use this web tool: https://www.base64-image.de/
- Certainly a good place to start looking at dummy-logos is this one: https://www.brandcrowd.com/maker/logos/

Sign-off:
Jan-4/2021: emmanuel.sosa@planetaweb.do
