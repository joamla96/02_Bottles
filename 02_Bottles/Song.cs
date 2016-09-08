using System;
using System.Diagnostics;

namespace _02_Bottles {
	internal class Song {
		internal string CountBottles(int v) {
			string verse = "";
			for(int i = v; i >= 0; i--) {
				if(i == 0) {
					verse = verse + " No more bottles of beer on the wall.";
				} else if(i == 1) {
					verse = verse + "1 bottle of beer on the wall."
					+ " 1 bottle of beer."
					+ " Take one down and pass it around.";
				} else {
					verse = verse + i + " bottles of beer on the wall. "
				+ i + " bottles of beer."
				+ " Take one down and pass it around. ";
				}
			}

			return verse;
		}
	}
}