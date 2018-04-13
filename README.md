# HashTable
A C# implementation of a Hash Table using chaining to avoid collisions.

### Installing
Just include the HashTable.cs file as a dependency upon compiling. So, for example, to compile the HashTableExample.cs which has the static void main() method and uses the Hash class in HashTable.cs you would run the following command in Unix:
```
csc /target:exe HashTableExample.cs HashTable.cs
```
Or in Windows:
```
csc.exe /target:exe HashTableExample.cs HashTable.cs
```
### Usage
See the HashTableExample.cs source code for an example which provides a command line utility to Add, Remove and Delete integers in a BST, as well as print the BST in a readable format. The command line utility accepts four commands:

# - Prints the number of elements in the hash table.

+<int> - Inserts <int> into hash table. For example: +4 
  
?<int> - Queries the hash table and returns "YES" if found or "NO" if not. Example: ?4 (would return "YES")
  
-<int> - Deletes an element from the hash table, if present. Example: -4 (now the table is empty)

### Todo
..* Only insert elements into the hash table if not already there.

..* Make generic.

..* Better error management.

### Issues
Permission denied when running HashTableExample.exe, you may need to run `chmod u+x HashTableExample.exe` to grant execute permissions.

