#include "stdafx.h"

namespace Process
{
	HANDLE hProc;
	uintptr_t moduleBase;
	DWORD dwExit = 0;
	m1 Memory;
	uintptr_t pCOORDS = 0x0D16D110;
	vector<unsigned int> OffsetsX = { 0x560, 0x90, 0x0, 0x1C0 };
	vector<unsigned int> OffsetsY = { 0x560, 0x90, 0x0, 0x1C8 };
	vector<unsigned int> OffsetsZ = { 0x560, 0x90, 0x0, 0x1D0 };
}

int main()
{
	//Set console
	_setWindow(60, 20);
	SetConsoleTitle(L"StarCitizen - Coords Grabber");

	//Start point , hook for later calls to return
	start: 

	//Base Process Variables
	const wchar_t* PROCESS = L"StarCitizen.exe";
	DWORD ProcID = proc::GetProcId(PROCESS);
	uintptr_t posX = 0, posY = 0, posZ = 0;
	double x = 0, y = 0, z = 0;
	
	//Begin branch , is process running?
    cout << "[+] Searching for Process . . ." << endl;
	Sleep(2000);
	if (ProcID)
	{
		//Establish Process Variables
		cout << "[+] Gathering Process Information . . ." << endl;
		Process::hProc = OpenProcess(PROCESS_ALL_ACCESS, NULL, ProcID);
		Process::moduleBase = proc::GetModuleBaseAddress(ProcID, PROCESS);
		Process::Memory = m1(Process::hProc);
		_clearConsole();
		cout << "READY" << endl;
	}
	else
	{
		//Error , Process not found
		string uINPUT;
		cout << "[+] Process not found . . . \n"
		"[+] Continue searching for the process? (Y/N)" << endl;
		cin >> uINPUT;
		if (uINPUT == "Y" || uINPUT == "y" || uINPUT == "YES" || uINPUT == "yes")
			goto start;
		else
			return 0;
	}

	//Main Loop
	while (GetExitCodeProcess(Process::hProc, &Process::dwExit) && Process::dwExit == STILL_ACTIVE)
	{
		if (GetAsyncKeyState(VK_NUMPAD9) & 1)
		{
			//buggy
			posX = mem::FindDMAAddy(Process::hProc, Process::moduleBase + Process::pCOORDS, { Process::OffsetsX });
			posY = mem::FindDMAAddy(Process::hProc, Process::moduleBase + Process::pCOORDS, { Process::OffsetsY });
			posZ = mem::FindDMAAddy(Process::hProc, Process::moduleBase + Process::pCOORDS, { Process::OffsetsZ });

			//Store Current Coordinates
			x = Process::Memory.Read<double>(posX);
			y = Process::Memory.Read<double>(posY);
			z = Process::Memory.Read<double>(posZ);
			cout << "COORDS" << endl;
			cout << fixed;
			cout << setprecision(14);
			cout << x << endl;
			cout << y << endl;
			cout << z << endl;
			cout <<"\n" << endl;
		}
	}
	//Error , Process not found
	string response;
	cout << "ATTENTION! \n"
		"[+] Process has either been closed or crashed . . . \n"
		"[+] Data has been preserved , record notes if needed . . . \n"
		"[+] Press [ENTER] to Continue (screen will clear) \n"
		"[+] Type 'END' to quit" << endl;
	cin >> response;
	if (response == "END" || response == "end") 
		return 0;
	else
		goto start;
}