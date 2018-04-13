class HashTableExample
{
	public static void Main()
	{
		Hash hash = new Hash();
		while ( true )
		{
			string line = ReadLine();
			char command = line[0];
			string argument = line.Substring(1);
			int.TryParse(argument, out int employeeNum);
			switch (command)
			{
				case '+':
					hash.add(employeeNum);
					break;
				case '-':
					hash.remove(employeeNum);
					break;
				case '?':
					WriteLine(hash.contains(employeeNum) ? "YES" : "NO");
					break;
				case '#':
					WriteLine(hash.count);
					break;
				case 'Q':
					return;
			}
		}
	}
}
