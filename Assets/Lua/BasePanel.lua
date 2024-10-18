Object:subClass("BasePanel")

BasePanel.panelObj = nil
BasePanel.controls = {}
BasePanel.isInitEvent = false

--实例化
function BasePanel:Init(name)
    if self.panelObj == nil then
        self.panelObj = ABMgr:LoadRes("ui", name, typeof(GameObject))
        self.panelObj.transform:SetParent(Canvas, false)
        print(self.panelObj)
        local allControls = self.panelObj:GetComponentsInChildren(typeof(UIBehaviour))
        --Button btn名字
        --Toggle tog名字
        --Image img名字
        --ScrollRect sv名字
        for i = 0, allControls.Length-1 do
            local controlName = allControls[i].name
            if string.find(controlName, "btn") ~= nil or 
               string.find(controlName, "tog") ~= nil or 
               string.find(controlName, "img") ~= nil or 
               string.find(controlName, "sv") ~= nil or
               string.find(controlName, "txt") ~= nil then
                local typeName = allControls[i]:GetType().Name
                --存储形式 例:
                --{ btnRole = { Image = Component组件, Button =  Component组件 },
                --  togItem = { Toggle =  Component组件} }
                if self.controls[controlName] ~= nil then
                    self.controls[controlName][typeName] = allControls[i]
                else
                    self.controls[controlName] = {[typeName] = allControls[i]}
                end
            end
        end
    end
end

--得控件
function BasePanel:GetControl(gameObjectName, typeName)
    if self.controls[gameObjectName] ~= nil then
        local sameNameControls = self.controls[gameObjectName]
        if sameNameControls[typeName] ~= nil then
            return sameNameControls[typeName]
        end
    end
    return nil
end

--显示面板
function BasePanel:ShowMe(name)
    self:Init(name)
    self.panelObj:SetActive(true)
end

function BasePanel:HideMe(is)
    self.panelObj:SetActive(false)
end
