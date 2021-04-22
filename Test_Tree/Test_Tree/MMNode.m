//
//  MMNode.m
//  Test_Tree
//
//  Created by Morris_ on 2021/4/20.
//

#import "MMNode.h"

@implementation MMNode

- (NSInteger)countNodes
{
    return CountNodes(self);
}

- (NSInteger)countLeaves
{
    return CountLeaves(self);
}

- (void)setTop:(MMNode *)top
{
    if (top) {
        if (!top.left) {        // 添加为左节点
            top.left = self;
        }
        else if (!top.right) {  // 添加为右节点
            top.right = self;
        }
        else {                  // 默认添加为左节点
            top.left = self;
        }
    }
}

int CountNodes(MMNode * node)
{
    if (node == nil) {
        return 0;
    }
    return CountNodes(node.left) + CountNodes(node.right) + 1;
}

int CountLeaves(MMNode * node)
{
    if (node == nil)
        return 0;

    if (!node.left && !node.right)
        return 1;

    return CountLeaves(node.left) + CountLeaves(node.right);
}

@end


