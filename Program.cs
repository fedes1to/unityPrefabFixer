Console.WriteLine("1 for first rename,\n2 for second rename");
ConsoleKeyInfo option = Console.ReadKey();

if (option.KeyChar == '1') {
    var exeFiles = Directory.EnumerateFiles("./", 
                                        "*", SearchOption.AllDirectories)
               .Where(s => s.EndsWith(".prefab"))
               .ToList();
               
string[] foundStuff = exeFiles.ToArray();

try { 
    for (int i = 0; i < foundStuff.Length; i++) {
    File.Move(foundStuff[i], foundStuff[i].Remove(foundStuff[i].Length - 7) + "fa.prefab");
} } catch {
    Console.WriteLine("unable to rename files, they're being used by a process already");
    Console.ReadLine();
}
} else if (option.KeyChar == '2') {
    var exeFiles1 = Directory.EnumerateFiles("./", 
                                        "*", SearchOption.AllDirectories)
               .Where(s => s.EndsWith("fa.prefab"))
               .ToList();
               
string[] foundStuff1 = exeFiles1.ToArray();

try { 
    for (int i = 0; i < foundStuff1.Length; i++) {
    File.Move(foundStuff1[i], foundStuff1[i].Remove(foundStuff1[i].Length - 9) + ".prefab");
} } catch {
    Console.WriteLine("unable to rename files, they're being used by a process already");
}}
