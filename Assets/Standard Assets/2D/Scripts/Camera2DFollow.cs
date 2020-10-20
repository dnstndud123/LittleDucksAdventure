using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Camera2DFollow : MonoBehaviour
    {
        GameObject player;
        public Transform target;
        public float damping = 1;
        public float lookAheadFactor = 3;
        public float lookAheadReturnSpeed = 0.5f;
        public float lookAheadMoveThreshold = 0.1f;

        private float m_OffsetZ;
        private Vector3 m_LastTargetPosition;
        private Vector3 m_CurrentVelocity;
        private Vector3 m_LookAheadPos;
        float xMoveDelta = 0;

        //[SerializeField] GameObject leftWall;
        //[SerializeField] GameObject rightWall;
        [SerializeField] Transform leftCam;
        [SerializeField] Transform rightCam;
        [SerializeField] Transform fallCam;
        [SerializeField] Vector2 AbsFallPos;
        //[SerializeField] BoxCollider2D col;
        public Vector2 leftWallPos;

        public Vector2 rightWallPos;

        [SerializeField] Vector2 fallPos;

        public Vector2 camRect;
        // Use this for initialization
        public void Init()
        {
            //leftWall = GameObject.Find("leftWall");
            //rightWall = GameObject.Find("rightWall");
            leftCam = GameObject.Find("leftCamWall").GetComponent<Transform>();
            rightCam = GameObject.Find("rightCamWall").GetComponent<Transform>();
            fallCam = GameObject.Find("fallCamWall").GetComponent<Transform>();
            //col = GameObject.Find("CamWall").GetComponent<BoxCollider2D>();
            player = GameObject.Find("Player");
            target = player.GetComponent<Transform>();
            m_LastTargetPosition = target.position;
            m_OffsetZ = (transform.position - target.position).z;
            fallPos = fallCam.position;
            AbsFallPos = fallPos;
            leftWallPos = leftCam.position;
            rightWallPos = rightCam.position;
            //transform.parent = null;
        }


        // Update is called once per frame
        private void Update()
        {

            // only update lookahead pos if accelerating or changed direction
            if (target != null)
            {
                //leftWallPos = leftWall.transform.position;
                //rightWallPos = rightWall.transform.position;
                camRect = transform.position;
                fallPos = fallCam.position; 
                


                xMoveDelta = (target.position - m_LastTargetPosition).x;
                

                bool updateLookAheadTarget = Mathf.Abs(xMoveDelta) > lookAheadMoveThreshold;

                if (updateLookAheadTarget)
                {
                    m_LookAheadPos = lookAheadFactor * Vector3.right * Mathf.Sign(xMoveDelta);
                }
                else
                {
                    m_LookAheadPos = Vector3.MoveTowards(m_LookAheadPos, Vector3.zero, Time.deltaTime * lookAheadReturnSpeed);
                }

                Vector3 aheadTargetPos = target.position + m_LookAheadPos + Vector3.forward * m_OffsetZ;
                Vector3 newPos = Vector3.SmoothDamp(transform.position, aheadTargetPos, ref m_CurrentVelocity, damping);

                /*
                GameObject camRect = col.gameObject;
                //BoxCollider2D boxCol = col;
                Vector3 camRectPos = camRect.transform.position;                
                float xLeft = camRectPos.x - col.size.x * 0.5f;
                float xRight = camRectPos.x + col.size.x * 0.5f;

                newPos.x = Mathf.Max(xLeft, newPos.x);
                newPos.x = Mathf.Min(xRight, newPos.x);
                */

                transform.position = newPos;




                //if (camRect.x - leftWallPos.x >= 11 || camRect.x - rightWallPos.x <= -11)
                if (camRect.x >= leftCam.transform.position.x && camRect.x <= rightCam.transform.position.x)
                {
                    target = player.transform;
                    if (camRect.y < fallPos.y)
                    {
                        fallPos.x = player.transform.position.x;
                        
                        target = fallCam;
                        if (player.transform.position.y > fallPos.y)
                        {
                            target = player.transform;
                        }
                    }
                    //pos.x = player.transform.position.x;
                }
                //if (camRect.x - leftWallPos.x < 11)
                else if (camRect.x < leftCam.position.x)
                {
                    
                    //camRect.x = leftWallPos.x + 10;
                    //pos.x = leftCam.transform.position.x;
                    
                    fallPos.x = leftWallPos.x;
                    fallCam.position = fallPos;

                    if (player.transform.position.y >= AbsFallPos.y)
                    {
                        
                        target = leftCam;
                        
                    }
                    else if (player.transform.position.y < AbsFallPos.y)
                    {
                        
                        target = fallCam;
                        
                    }


                    
                    

                    if (player.transform.position.x > leftWallPos.x)
                    {
                        fallPos = AbsFallPos;
                        fallCam.position = AbsFallPos;
                        target = player.transform;
                    }
                }
                //if (camRect.x - rightWallPos.x > -11)
                else if (camRect.x > rightCam.position.x)
                {
                    
                    //camRect.x = rightWallPos.x - 10;
                    //pos.x = rightCam.transform.position.x;
                    
                    fallPos.x = rightWallPos.x;
                    fallCam.position = fallPos;


                    if (player.transform.position.y >= AbsFallPos.y)
                    {
                        
                        target = rightCam;
                        
                    }
                    else if (player.transform.position.y < AbsFallPos.y)
                    {
                        
                        target = fallCam;
                    }

                    
                    
                    if (player.transform.position.x < rightWallPos.x)
                    {
                        fallPos = AbsFallPos;
                        fallCam.position = AbsFallPos;
                        target = player.transform;
                    }
                }

                
                m_LastTargetPosition = target.position;
                m_OffsetZ = (transform.position - target.position).z;

                
            }


        }
    }
}
