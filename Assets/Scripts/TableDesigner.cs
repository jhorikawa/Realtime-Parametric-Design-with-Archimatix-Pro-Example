using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AX;

public class TableDesigner : MonoBehaviour {
    public AXModel model;

    public AXParameter p_radius;
    public AXParameter p_height;
    public AXParameter p_thickness;

	// Use this for initialization
	void Start () {
		if(model != null)
        {
            p_radius = model.getParameter("Chair_radius");
            p_height = model.getParameter("Chair_height");
            p_thickness = model.getParameter("Chair_thickness");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateRadius(float val)
    {
        p_radius.initiateRipple_setFloatValueFromGUIChange(val);
        model.isAltered();

    }

    public void UpdateHeight(float val)
    {
        p_height.initiateRipple_setFloatValueFromGUIChange(val);
        model.isAltered();
    }

    public void UpdateThickness(float val)
    {
        p_thickness.initiateRipple_setFloatValueFromGUIChange(val);
        model.isAltered();
    }
}
