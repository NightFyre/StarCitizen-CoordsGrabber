#include "stdafx.h"

//Empty Process info
HANDLE hProc;
uintptr_t moduleBase;
DWORD dwExit = 0;
m1 Memory;

int main()
{
	//Set console
	_setWindow(60, 20);
	SetConsoleTitle(L"StarCitizen - Coords Grabber");

	//Start point , hook for later calls to return
	start: 

	//Base Process Variables
	const wchar_t* PROCESS = L"StarCitizen.exe";
	DWORD ProcID = GetProcId(PROCESS);
	uintptr_t posX = 0, posY = 0, posZ = 0;
	double x = 0, y = 0, z = 0;
	
	//Begin branch , is process running?
    cout << "[+] Searching for Process . . ." << endl;
	Sleep(2000);
	if (ProcID)
	{
		//Establish Process Variables
		cout << "[+] Gathering Process Information . . ." << endl;
		hProc = OpenProcess(PROCESS_ALL_ACCESS, NULL, ProcID);
		moduleBase = GetModuleBaseAddress(ProcID, PROCESS);
		Memory = m1(hProc);
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
	while (GetExitCodeProcess(hProc, &dwExit) && dwExit == STILL_ACTIVE)
	{
		if (GetAsyncKeyState(VK_NUMPAD9) & 1)
		{
			//buggy
			posX = FindDMAAddy(hProc, moduleBase + pPOSptr, { 0x150, 0xB0, 0x268, 0x0, 0x1C0 });
			posY = FindDMAAddy(hProc, moduleBase + pPOSptr, { 0x150, 0xB0, 0x268, 0x0, 0x1C8 });
			posZ = FindDMAAddy(hProc, moduleBase + pPOSptr, { 0x150, 0xB0, 0x268, 0x0, 0x1D0 });

			//Store Current Coordinates
			x = Memory.Read<double>(posX);
			y = Memory.Read<double>(posY);
			z = Memory.Read<double>(posZ);
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