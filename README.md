# GameManager
System to store the RPG items in a hierarchical structure. 

The functional scope includes: 
- Displaying data in the catalog by category.

    Items are grouped by category. 
    
- Searching and filtering of categories or instances by many different categories. 

    Filters depend on the defined categories and characters. It's created dynamically.  
    
- Adding new items and categories to the catalog. 

    Forms provide text fields to set all attributes. When editing or adding an item, the assignment to a category is done through a one-choice list.
    
- Delete items and entire categories. 
    
- Modification of elements and categories of the catalog. A solution should be prepared to allow editing of existing elements and categories.  

    Both adding and editing is implemented using the same solution. 
- The main page of the application displays a list of the TOP 5 strongest characters and a list of news items with the number of recently added artifacts displayed. 

    The number of artifacts displayed is determined by the user ( default 5) . The list is updated when artifacts are added, removed or modified. 
    
Bigest challange was to implement the tree structure in the database. Eventually, it was done with help of [Closure Table.](https://www.red-gate.com/simple-talk/databases/sql-server/t-sql-programming-sql-server/sql-server-closure-tables/) 
<br>
![Tree Structure](https://github.com/bartekf4/GameManager/blob/master/GameManager/Images/categories.png)


## Screenshots

![Welcome Window](https://github.com/bartekf4/GameManager/blob/master/GameManager/Images/welcome.png)

![Main Window](https://github.com/bartekf4/GameManager/blob/master/GameManager/Images/main.png)
