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

P - Prints the tree, sideways, such that the root is on the left and higher values are above lower ones.

I <int> - Inserts <int> into tree. For example: I 4 
  
Q <int> - Queries the tree and returns "Present" if found or "Absent" if not. Example: Q 4 (would return "Present)
  
D <int> - Deletes an element from the tree, if Present. Example: D 4 (now the tree is empty)

### Todo
..* Only insert elements into the hash table if not already there.
..* Make generic.
..* Better error management.

### Issues
Permission denied when running HashTableExample.exe, you may need to run `chmod u+x HashTableExample.exe` to grant execute permissions.

