using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

namespace Oculus.Interaction
{
    public class Weightscript : MonoBehaviour
    {

        public float wei = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider Coll)
        {
            if (Coll.GetComponent<Rigidbody>())
            {
                wei += Coll.GetComponent<Rigidbody>().mass;
            }
        }

        void OnTriggerExit(Collider Coll)
        {
            if (Coll.GetComponent<Rigidbody>())
            {
                wei -= Coll.GetComponent<Rigidbody>().mass;
            }
        }

        public float num()
        {
            return wei;
        }
    }
}
