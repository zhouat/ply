#!/bin/ply

kprobe:SyS_open {
	/* opens[comm()] += 1; */
	/* trace("pc: %p\n", reg("pc")); */
	/* opens[0, 1, "hejsansaaa"] += 1; */
	/* opens[0] = "hej"; */
	/* test[0] = opens["hoj", 0x1337, 1]; */
	/* opens["lol", 1, 1] = ["wow", "hej"]; */
	opens[reg("pc")] += 1;
}
