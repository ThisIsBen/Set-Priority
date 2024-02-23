# Set-Priority

Scheduling Priorities of a process and a thread in C# 
<https://learn.microsoft.com/en-us/windows/win32/procthread/scheduling-priorities>


Get the priority of a process:
<https://learn.microsoft.com/ja-jp/dotnet/api/system.diagnostics.process.priorityclass?view=net-7.0>


Set the priority of a process:
Try setting the PriorityClass AFTER you start the process. Task Manager works this way, allowing you to set priority on a process that is already running.
<https://stackoverflow.com/questions/1010370/how-do-i-launch-a-process-with-low-priority-c-sharp>

```
Process app = new Process();
app.StartInfo.FileName = @"bin\convert.exe";
app.StartInfo.Arguments = TheArgs;
app.Start();
app.PriorityClass = ProcessPriorityClass.BelowNormal;
```


Set the priority of a thread：
<https://dotnettutorials.net/lesson/threads-priorities-in-csharp/>
```
Thread thread1 = new Thread(SomeMethod)
{
  Name = "Thread 1"
};
//Setting the thread Priority as Normal
thread1.Priority = ThreadPriority.Normal;
```
