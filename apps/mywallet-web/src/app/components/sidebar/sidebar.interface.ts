export interface SidebarCategory {
  header?: string;
  items?: SidebarItem[];
}

export interface SidebarItem {
  name: string;
  icon?: SidebarIcon;
  link?: string;
}

export interface SidebarIcon {
  name: string;
  color: string;
}
