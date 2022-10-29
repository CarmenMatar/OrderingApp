# OrderingApp
Ordering App using Xamarin Forms, BMB assessment
Functionalities Done:
Created Three Views:
LoginPage (login with username : test , password: 1234) 
Didn’t have much time to store users in the SQLite Database so used this user statically to demonstrate the login activity.
listingPage
For the listing, when opening it first refresh the page by swiping done and the orders saved in the SQLite Database will be fetched. 
Click on the Edit button to open the order’s information and edit it.
Click on the Delete Button to delete the order.
infoPage
In this page, it is solely for creating new orders or editing old ones.
Cancel button takes back to listing page.
Save button, after Save takes back to listing oage.
Properties used:
Xamarin Forms
C#
MVVM
SQLite
Shell for navigation
Conclusion:
In general, this was a very challenging assessment, and I tried my best to finish as much as I can since I worked with some new concepts.
Used the MVVM flow to try and divide the xaml code and code behind from the functions of this app.
So the view models are responsible for the functionality of the app.
Introduced a few services, to combine all functions related to Orders and to use them in an efficient way in the view models related to the models.

NB:
Make sure the required Nuget Package is installed in main solution and in the android part before running the app. (sqlite-net-pcl)
