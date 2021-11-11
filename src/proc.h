#pragma once
#include "stdafx.h"
///Credit: GuidedHacking
// Check out the website and youtube channel
//GHB1 Tutorials 11 - 16

DWORD GetProcId(const wchar_t* procName);

uintptr_t GetModuleBaseAddress(DWORD procId, const wchar_t* modName);

uintptr_t FindDMAAddy(HANDLE hProc, uintptr_t ptr, std::vector<unsigned int> offsets);

uintptr_t PS2_FindDMAAddy(HANDLE hProc, uintptr_t ptr, std::vector<unsigned int> offsets);