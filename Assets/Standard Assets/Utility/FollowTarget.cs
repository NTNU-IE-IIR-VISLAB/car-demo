using System;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Boolean rotation;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);

        private void Update()
        {
            transform.position = target.position + offset;
            if (rotation)
            {
                transform.rotation = target.rotation;
            }
        }
    }
}