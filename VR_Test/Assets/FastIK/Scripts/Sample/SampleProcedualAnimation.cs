using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.XR;
using Valve.VR;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

 public class SampleProcedualAnimation :  MonoBehaviour
    {
    public GameObject TargetHandLeft;
    public GameObject TargetHandRight;

    void Start()
    {
      
    }
     void Update()
        {

        TargetHandLeft.transform.SetPositionAndRotation(
            InputTracking.GetLocalPosition(XRNode.LeftHand),
            InputTracking.GetLocalRotation(XRNode.LeftHand));

        TargetHandRight.transform.SetPositionAndRotation(
           InputTracking.GetLocalPosition(XRNode.RightHand),
           InputTracking.GetLocalRotation(XRNode.RightHand));
    }

    }

