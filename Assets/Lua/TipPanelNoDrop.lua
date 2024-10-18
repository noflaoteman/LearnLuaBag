BasePanel:subClass("TipPanelNoDrop")

Object:subClass("TipData")
TipData.isAlpha = false

function TipPanelNoDrop:Init(name)
    self.base.Init(self, name)
    if self.isInitEvent == false then
        
        self.isInitEvent = true
    end
end


--显示
function TipPanelNoDrop:ShowMe(name)
    self.base.ShowMe(self, name)
end

-- 通过rectTransform显示
function TipPanelNoDrop:ShowPanelByRect(rectTransform,txtInfo,tipData)
    local screenPosition = RectTransformUtility.WorldToScreenPoint(Camera.main, rectTransform.position)
	self:ShowPanelBy(screenPosition,tex,tipData)
end

-- 通过screenPosition显示
function TipPanelNoDrop:ShowPanelByScreenPos(screenPosition,txtInfo,tipData)
    self:ShowMe("TipPanelNoDrop")
    self.panelObj:GetComponent(typeof(CanvasGroup)):DOFade(1, 1);
    local uiPanelPos = Vector2.zero
    local success, uiPanelPos = RectTransformUtility.ScreenPointToLocalPointInRectangle(
        self.panelObj.transform.parent, 
        screenPosition, 
        Camera.main)
    
    if success then
        self:GetControl("txtDes", "Text").text = txtInfo
        uiPanelPos.y=uiPanelPos.y+100 
        self:SetPos(uiPanelPos)
    end 

    --一定要先设置Panel的坐标!!一定要先设置Panel的坐标!!一定要先设置Panel的坐标!!
    local imgPointPos = Vector2.zero
    local success, imgPointPos = RectTransformUtility.ScreenPointToLocalPointInRectangle(
        self:GetControl("imgPoint", "Image").transform.parent, 
        screenPosition, 
        Camera.main)
    local imgPointPosV3 = Vector3(imgPointPos.x, imgPointPos.y+10, self:GetControl("imgPoint", "Image").transform.localPosition.z)
    self:GetControl("imgPoint", "Image").rectTransform.localPosition = imgPointPosV3
end

-- 设置位置，控制Panel不超出边界
function TipPanelNoDrop:SetPos(uiPoint)
    local rightTopUIpoint = Vector2.zero
    local success, rightTopUIpoint = RectTransformUtility.ScreenPointToLocalPointInRectangle(
        self.panelObj.transform.parent,
        Vector2(CS.UnityEngine.Screen.width, CS.UnityEngine.Screen.height),
        Camera.main)

    if not success then
        return
    end

    local screenWidth = rightTopUIpoint.x
    local screenHeight = rightTopUIpoint.y

    local rect = self.panelObj:GetComponent(typeof(CS.UnityEngine.RectTransform))
    local imgHalfWidth = rect.sizeDelta.x / 2
    local imgHalfHeight = rect.sizeDelta.y / 2

    -- 计算新的位置
    local rectLocalPosition = CS.UnityEngine.Vector3(uiPoint.x, uiPoint.y, rect.localPosition.z)

    if rectLocalPosition.x > (screenWidth - imgHalfWidth) then
        rectLocalPosition.x = screenWidth - imgHalfWidth
    end
    if rectLocalPosition.y > (screenHeight - imgHalfHeight) then
        rectLocalPosition.y = screenHeight - imgHalfHeight
    end

    if rectLocalPosition.x < -screenWidth + imgHalfWidth then
        rectLocalPosition.x = -screenWidth + imgHalfWidth
    end
    if rectLocalPosition.y < -screenHeight + imgHalfHeight then
        rectLocalPosition.y = -screenHeight + imgHalfHeight
    end

    -- 设置UI的位置
    self.panelObj.transform.localPosition = rectLocalPosition
end


--关闭提示面板
function TipPanelNoDrop:btnCloseClick()
    self.panelObj:GetComponent(typeof(CanvasGroup)):DOFade(0, 1);
end

