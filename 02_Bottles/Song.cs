using System;
using System.Diagnostics;

namespace _02_Bottles {
	internal class Song {
		private bool first = true;
		private string bottle = "bottles";
		internal string CountBottles(int v) {
			string verse = "";
			for(int i = v; i >= 0; i--) {
				if(i == 0) {
					verse = verse + " No more bottles of beer on the wall.";
				} else {
					if (i == 1) bottle = "bottle";

					if(first) {
						verse = i + " "+ bottle +" of beer on the wall. "
							+ i + " " + bottle + " of beer."
							+ " Take one down and pass it around.";
						first = false;
					} else {
						verse += " " + i + " " + bottle + " of beer on the wall. "
							+ i + " " + bottle + " of beer on the wall. "
							+ i + " " + bottle + " of beer."
							+ " Take one down and pass it around.";
					}
				}
			}

			return verse;
		}
	}
}