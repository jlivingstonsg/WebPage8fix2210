# WebPage8

Close VS 2019 and delete the two folders ".vs" and "bin" to get a working project in VS 2019.

To get update on database!!!
Erase sql database "ComputerWebShop2"
Run in Package Manager Consol
PM>add-migration categoryData
PM>update-database



Problem opening webpage?  <br>
In appsettings.json    <br>
Unmomment this code.    <br>
"ComputerWebShop": "Server=(localdb)\\mssqllocaldb;Database=ComputerWebShop2;Trusted_Connection=True;MultipleActiveResultSets=true"    <br>
and comment out the other one    <br><br>

Good luck  :)


Regards 
