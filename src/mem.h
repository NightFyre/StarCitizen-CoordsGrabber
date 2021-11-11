#pragma once
#include "stdafx.h"
///Credit: GuidedHacking
// Check out the website and youtube channel
//GHB1 Tutorials 11 - 16

namespace mem
{
	void PatchEx(BYTE* dst, BYTE* src, unsigned int size, HANDLE hProcess);
	void NopEx(BYTE* dst, unsigned int size, HANDLE hProcess);
	void PS2NopEx(BYTE* dst, unsigned int size, HANDLE hProcess);
}

class m1
{
public:
	m1() {};
	HANDLE CurrentProcess = new HANDLE();
	m1(HANDLE hProcess)
	{
		CurrentProcess = hProcess;
	}

	template <typename T>
	void Write(uintptr_t Address, T value)
	{
		WriteProcessMemory(CurrentProcess, (BYTE*)Address, &value, sizeof(value), 0);
	}

	template <typename T>
	T Read(uintptr_t Address)
	{
		T val;
		ReadProcessMemory(CurrentProcess, (BYTE*)Address, &val, sizeof(T), 0);
		return val;
	}

	uintptr_t FindDMAAddy(uintptr_t addr, std::vector<unsigned int> offsets)
	{
		for (UINT i = 0; i < offsets.size(); i++)
		{
			ReadProcessMemory(CurrentProcess, (BYTE*)addr, &addr, sizeof(addr), 0);
			addr += offsets[i];
		}
		return addr;
	}
};