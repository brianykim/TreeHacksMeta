//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;
//using System;
using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

namespace AssemblyCSharp
{
	public class PedalMyo
	{
		public GameObject myo = null;
		public Quaternion pitch = Quaternion.identity;
		public PedalMyo ()
		{

		}
		void Update() {
			ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();
			Vector3 antigravity = Vector3.up;
			Vector3 m = Vector3.Cross (myo.transform.forward, antigravity);
			Vector3 roll = Vector3.Cross (m, myo.transform.forward);
			Vector3 pitch = Vector3.Cross (roll, myo.transform.forward);//Quaternion.
			//print(
		}
	}
}

