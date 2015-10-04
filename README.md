# ConsoleApplicationOutput
Read output of a console application inside other application types including web.

Legacy COBOL applications deal with strings. The executable take string parameters and return string in their output. This is different then referencing a dll, calling methods on it with cutom types, and getting custom types back.

This C# solution provides a way to remove a COBOL executable with a .Net executable, without any dependency changes. You just replace the exe file in the folder.

This also demonstrates the capability of getting the output from an executable to a web application.

CONTENTS
ConsoleApplication - executable which takes a parameter, processes it and writes output to console.
ConsoleApplicationOutputGet - executable which calls(executes) ConsoleApplication and gets the output from it back as a string.
ConsoleApplicationHost - web application which calls(executes) ConsoleApplication and gets the output from it back as a string.

