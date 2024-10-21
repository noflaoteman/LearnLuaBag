require("InitClass")
require("ItemData")
require("PlayerData")
PlayerData:Init()

require("BasePanel")
require("MainPanel")
require("BagPanel")
require("ItemGrid")
require("TipPanel")
require("TipPanelNoDrop")
--MainPanel:ShowMe("MainPanel")

--鼠标左键输入监听
InputManager.MouseDownLeftAction = function ()
	local screenPosition = Vector2.zero
	screenPosition.x=Input.mousePosition.x
	screenPosition.y=Input.mousePosition.y
	local tipData = {isAlpha = true,isUp = true,tipContentText = "fjdlkafjdlkfjadsklfjdlk",isTypeText=true}
	TipPanelNoDrop:ShowPanelByScreenPos(screenPosition,tipData)
end

--鼠标右键输入监听
InputManager.MouseDownRightAction = function ()
	TipPanelNoDrop:btnCloseClick()
end
