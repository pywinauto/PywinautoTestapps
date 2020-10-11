//
//  ViewController.swift
//  ControlsTestAppSB
//
//  Created by artem zemtsov on 18.05.2020.
//  Copyright © 2020 pywinauto. All rights reserved.
//

import Cocoa
import Quartz

class ViewController: NSViewController {
    
    @IBOutlet weak var clickedControlLabel: NSTextField!
    @IBOutlet weak var button: NSButton!
    @IBOutlet weak var TexturedRoundedButton: NSButton!
    @IBOutlet weak var recessedButton: NSButton!
    @IBOutlet weak var inlineButton: NSButton!
    @IBOutlet weak var itemButton: NSPopUpButton!
    @IBOutlet weak var checkbox: NSButton!
    @IBOutlet weak var squareButton: NSButton!
    @IBOutlet weak var roundedRectButton: NSButton!    
    @IBOutlet weak var radioButton: NSButton!

    @IBAction func buttonPressed(_ sender: Any)                {updateLastLabel(for: "button")}
    @IBAction func texturedRoundedButtonClicked(_ sender: Any) {updateLastLabel(for: "texturedRoundedButton")}
    @IBAction func roundedRectButtonPressed(_ sender: Any)     {updateLastLabel(for: "roundedRectButton")}
    @IBAction func squareButtonPressed(_ sender: Any)          {updateLastLabel(for: "squareButton")}
    @IBAction func recessedButtonPressed(_ sender: Any)        {updateLastLabel(for: "recessedButton")}
    @IBAction func inlineButtonPressed(_ sender: Any)          {updateLastLabel(for: "inlineButton")}
    @IBAction func itemButtonPressed(_ sender: Any)            {updateLastLabel(for: "itemButton")}
    @IBAction func checkboxPressed(_ sender: Any)              {updateLastLabel(for: "checkbox")}
    @IBAction func radioButtonPressed(_ sender: Any)           {updateLastLabel(for: "radioButton")}
    
    
    override func viewWillAppear() {
        super.viewWillAppear()
        // Remove the line below if you need to debug UI
        clickedControlLabel.isHidden = true
    }
    
    private func updateLastLabel(for lastSelectedControl:String) {
        clickedControlLabel.stringValue = lastSelectedControl
    }

}

